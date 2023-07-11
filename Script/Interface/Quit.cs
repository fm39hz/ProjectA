using Godot;

namespace ProjectA.Script.Interface;
	public partial class Quit : Button{
    public override void _Pressed(){
        base._Pressed();
    	GetTree().Quit();
		}
}
