using Confluent.Kafka;
using System.Text;
namespace KafkaChatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            using var producer = new ProducerBuilder<Null, string>(config).Build();

            try
            {
                var result = producer.ProduceAsync(
                    txtTopic.Text,
                    new Message<Null, string>
                    {
                        Value = txtMessage.Text
                    }).Result;

                lstMessages.Items.Add("Sent: " + txtMessage.Text);

                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var config = new ConsumerConfig
                {
                    BootstrapServers = "localhost:9092",
                    GroupId = Guid.NewGuid().ToString(),
                    AutoOffsetReset = AutoOffsetReset.Earliest
                };

                using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();

                consumer.Subscribe(txtTopic.Text);

                while (true)
                {
                    try
                    {
                        var result = consumer.Consume();

                        Invoke(() =>
                        {
                            lstMessages.Items.Add("Received: " + result.Message.Value);
                        });
                    }
                    catch (Exception ex)
                    {
                        Invoke(() =>
                        {
                            MessageBox.Show(ex.Message);
                        });
                    }
                }
            });
        }
    }
}
