###############################################################
Shrikant B. Darekar
Sadu Consultancy Services | www.saducs.com | Mob.9765975757
###############################################################
This is a simple C# windows application developed using
Visual Studio 2019 Community Edition,
will be useful for beginners.

It shows how to use Form's "DialogResult" property.
Application has three forms: Splash,Login,Dashboard

In Program.CS, we create instance of FormSplashScreen, 
it appears for 5 seconds.
Then FormLogin starts execution, 
it handles action for Login and Exit buttons.
On login sussess, FormDashboard displayed. 
On Exit click, application ends.
That's all.

###############################################################

Splash Form:
This is a simple form, shows some welcome or splash message 
regarding your application.

Login Form:
This form has textboxes for user id and and password. 
Two buttons Login and Exit. 
On Login button, user can check user id and password using 
database logic and set Form's "DialogResult" value as per result.
Here we have used DialogResult.OK for valid login details and 
DialogResult.Cancel for invalid login details.

FormDashboard:
This form contain heading and menu. Exit menu on click closes
application.

###############################################################