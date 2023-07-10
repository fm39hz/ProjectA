using Godot;

namespace ProjectA.Script.Interface;
	public partial class Settings : Button{
		public override void _Ready(){
			}
		public override void _PhysicsProcess(double delta){
			}

		public override void _Pressed(){
			base._Pressed();
			GD.Print("EnteredSettingsMenu");
			}
		}
