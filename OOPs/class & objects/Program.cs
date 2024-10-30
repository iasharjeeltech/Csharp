using class___objects;

Messagess msg = new Messagess();

msg.Name = "Sharjeel";
msg.LastName = "Ansari";
msg.MobNo = 8149575027;

msg.Hello();
Console.WriteLine($"{msg.Name} {msg.LastName}");
msg.Waiting();
Console.WriteLine(msg.MobNo);
msg.By();