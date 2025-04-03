Visual studio version: 17.13.3 and 17.13.5
Codist version: 7.9.5.9983

I have all extensions disabled except Codist. 

Reproduction steps:

1. Created basic ASP.NET Core Web API Project
2. In Program.cs , create variable `var test="test";`
3. Create public class - NewClass.cs
4. Create function in NewClass.cs and in body start typing:
     `var crash = test      <-- crash because cursor on test property or click on property since it has red underline`
6. After reopening project it will put cursor on the same place, crashing VS again.

I tested this on  colleague PC with same results. Seems that on VS17.13.0 there is no issue with this.

Thank you


