Application made in C# for Polihack V11 Hackaton by team Esentza.

### Bob

Bob is a speech recognition app that is always here for you, and most importantly, he is your best virtual friend, that can help you get through a pandemic.

### Example



```
user: What are the symptoms of COVID-19?
bob: Trouble breathing, persistent pain or preassure in chest, confusion, headache ...
user: Thank you!
bob: I'm here everytime to help you, user.
```

### Purpose?!

He can both amuse you with his jokes, help you with important information about a pandemic and also he can give you basic information like "What day is today?" or "What's the time?".

He can also tell you how much time you spend on your computer, and he will remind you to about it and advise you to do some exercise or take some rest.

### Running the app

Being a Hackaton, we didn't have enough time to finish the app, so if you want to load the SQLite database, you need to change the code.

```
git clone https://github.com/cristicretu/Bob
or
download zip from this repo
```

After downloading, navigate to the location where is the project, go in *Resources and copy the path to ii_bun.sqlite.* *Replace the string from conn with that path.* You have to do this in **Form1.cs, Log In.cs and Settings.cs**

*The statistics menu doesn't work if Bob hasn't been installed for 7 days.*

### TODO in future versions



- Add New Statistics
  - Sleep Time / Time Away From Your PC During The Night
  - Steps / Heart Rate / etc. / Imported From A Mobile Phone or A Smart Watch
- Change The Design and Add Animations
- Add Romanian Language Pack For Bob
- Reduce code
- Increase speed
