
# Кој Сака Да Биде Милионер? 

Windows Forms Project by: Blagoj Petrov (173024)


# Опис на Апликацијата
Со цел за да се обезбеди задоволство кај играчот, покрај едноставно имплементираниот интерфејс и дизајн (кои што е направен базирајќи се врз самото TV Show Who wants to be a millionaire?), имплементирани се и различни алгоритми кои што служат за сортирање и мешање на прашањата по случаен редослед, па дури и одговорите со цел корисникот секој пат да добива различни прашања со кои ќе може повеќе да се задржи вниманието на корисникот (односно играта да стане монотона и досадна). *


## Упатство за користење
 **1. Опис на интерфејсот**
	Интерфејсот со цел корисникот да се фокусира на прашањата (поради тоа што има време за секое прашање) е многу едноставен и лесен за управување (Слика. 1). Тој се состој од 4 главни компоненти:
	- **Главно мени** (кое служи за прегледност, односно до кое прашање е стигнат корисникот, како и специјалните опции "Повикај Пријател" и ,"50:50" се дел од него)
	- **Дел со копчиња** (односно радио дугмиња за самите прашања и стандарно копче за потврдување/започнување - во зависност од ситуацијата)
	- **Дел со техт** (делот каде водителот "Тарик" поставува прашања и упатства, односно дел кој што се користи за соопштување)
	- **Дел со тајмер** (кој што го покажува преостанатато време за прашањето) и максимален постигнат резултат(максимално достигнато прашање)  
	
 **2. Нова Игра**
- На почетниот прозорец (слика 1) при стартување на апликацијата имаме можност да започнеме нова игра  **(На зеленото копче Start Game)**.
![Слика бр. 1](https://user-images.githubusercontent.com/50581470/92279391-7b3ab800-eef7-11ea-8298-878e284e26e3.PNG)
 - По започнување на играта се генерира и добива првото прашање (по случаен избор користејќи алгоритам) и корисникот има 15 секунди да одлучи за точниот одговор во спротивно тој ќе изгуби. Корисникот има и опција за помош, односно може да повика пријател (Пријателот 80% од времето е точен, меѓутоа се случува и да згрежи односно останатите 20%) или да избери 50:50 (ова опција по случаен избор бриши две од четирите можни опции). Во играта додадена е и опција за мерење на највисокото постигнато прашање (со цел да се јаве ривалство и компетиција, ако два или повеќе корисници ја користат играта) (Слика бр.2). Неколку главни точки кои што треба да се памтат при играње/користињере на апликацијата:
 -- Доколку корисникот го одбери точниот одговор, копчето светнува зелено и тој може да продолже понатаму (Слика бр. 2.1)
 -- Корисникот може да изгубе на два начини: со истекување на времето или грешно одберен одговор, во двата случаеви дугмето светнува црнува и играта започнува од ново со Тарик давајќи упатство (Слика бр. 2.2)
 -- Играта може да се игра неограничен број на пати
 -- Корисникот може да побара помош од пријател или 50:50 (Слика бр. 2.3, Слика бр. 2.4), но само по еднаш во циклус
 -- Во моментот играта содржи само 15 прашања кои секогаш се поставуваат различно, како и 4 одговори за секое прашање (но на различно место, со цел корисникот да не може визуелно да го запамети одговорот). Секогаш има опција за додавање на повеќе прашања.
 -- Доколку корисникот ја заврши играта Тарик го известува со позитивна порака и може играта да ја почни одново
 ![Слика бр 2](https://user-images.githubusercontent.com/50581470/92279396-7d9d1200-eef7-11ea-9fe0-698c92e9b1c1.PNG)
 ![Слика бр. 2.1](https://user-images.githubusercontent.com/50581470/92279401-7fff6c00-eef7-11ea-9efb-56ea779ab2af.PNG)
 ![Слика бр 2.2](https://user-images.githubusercontent.com/50581470/92279399-7ece3f00-eef7-11ea-8b99-8e47e185a2a4.PNG)
 ![Слика бр 2.3](https://user-images.githubusercontent.com/50581470/92279379-770e9a80-eef7-11ea-9602-39d520e89392.PNG)
 ![Слика бр 2.4](https://user-images.githubusercontent.com/50581470/92279387-7a098b00-eef7-11ea-85b4-a1cb76ab6481.PNG)





## Претставување на проблемот

**1.**Податочни структури****
 - Апликацијата содржи една главна класа Form во скоја се имплементирани сите методи и помошни функции потребни за функционалноста на апликацијата. 

 

>      public partial class Form1 : Form
>     {
>         private int iSlide;
>         private string rightAnswer;
>         private Boolean playerLost;
>         private int[] randomNums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10 ,11, 12, 13, 14, 15 };
>         private int timeLeft;
>         private int highestScore;
>         public Form1()
>         {
>             InitializeComponent();
>             iSlide = 0;
>             rightAnswer = "";
>             playerLost = false;
>             timeLeft = 15;
>             highestScore = 0;
>         }

 1. Прашањата (15) и нивните одговори се чуваат локално. користејќи низи односно тие се ставени во функции кои што се задолжени да ги генерираат кога ќе бидат повикан (Тие се повикани случајно поради тоа што пред да се повикаат се прави shuffle на низата 		  randomNums која се користи токму за тоа).
            
    private void Question1(int questionNum)
            {
                 label2.Text = questionNum.ToString() + ". What is the full real name of the YouTuber?";
    
                string[] answers = { "Felix Arvid Ulf Kjellberg", "Felix Arvid ", "Felix Thor Baze Teiller", "Ingrid Olaf Kalleh Trailler" };
                string correctAnswer = "Felix Arvid Ulf Kjellberg";
    
                this.answersShuffleHandler(answers, correctAnswer);
               
             }
             
    // Функција за рандомизирање на одговорите
     private void answersShuffleHandler(string[] answers, string correctAnswer)
        {
            RadioButton[] radioButtons = { radioButton1, radioButton5, radioButton6, radioButton7 };

            shuffleArray<string>(answers);

            for (int i = 0; i < answers.Length; i++)
            {
                if (correctAnswer == answers[i])
                {
                    switch (i)
                    {
                        case 0:
                            this.rightAnswer = "A";
                            break;
                        case 1:
                            this.rightAnswer = "C";
                            break;
                        case 2:
                            this.rightAnswer = "B";
                            break;
                        case 3:
                            this.rightAnswer = "D";
                            break;
                    }
                }
                radioButtons[i].Text = answers[i];
            }
        }

 2. Во повеќето функции каде што имам избирања на "нешта" по случаен избор го користам сличниот принцип како во горниот код, односно прво (при лодирање на формата или при избор на новото прашање во зависност од ситуацијата) ја мешам низата корисејќи ја функцијата/методот **shuffleArray** направена за прифакање на секоја низа низи од било кој тип и  мешање на истата. 
 3. Креирани се и многу помошни фунции/методи кои што може да се видат во кодот пр. **rightAnswerChecker(answer, radioButton)**, **disableOthers(radioButton)**, **randomQuestionGenerator**, **questionPicker** etc.. 
**2.** **Алгоритам**
Користен алгоритам за мешање(shuffle) на низа по случаен избор:
   

    >     private void shuffleArray<T>(T [] array)
    >             {
    >                 Random rnd = new Random();
    >               
    >                 int n = array.Length;
    >                 while (n > 1)
    >                 {
    >                     int k = rnd.Next(n--);
    >                     T temp = array[n];
    >                     array[n] = array[k];
    >                     array[k] = temp;
    >                 }
    >             }

