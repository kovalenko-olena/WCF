using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MagicEightBallServiceLib
{
    [ServiceContract(Namespace = "http://MyCompany.com")]
    public interface IEightBall
    {
        // Задайте вопрос, получите ответ!
        [OperationContract]
        string ObtainAnswerToQuestion(string userQuestion);
    }
}
