# CrazyButton
![](https://github.com/merisahakyan/CrazyButton/blob/master/crazy.gif)
Add the _button1_MouseMove(object sender, MouseEventArgs e)_ handler and your button would fly too :smile:
```cs
private void button1_MouseMove(object sender, MouseEventArgs e)
{
    Random r = new Random();
    int bx = r.Next(10, ClientSize.Width - button1.Width);
    int by = r.Next(10, ClientSize.Height - button1.Height);
    button1.Location = new Point(bx, by);
}
```
