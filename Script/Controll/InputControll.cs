using Godot;
using ProjectA.Script.Interface;

namespace ProjectA.Script.Controll;
	public partial class InputControll : Control{
		private MainMenu Menu { get; set; }
		public override void _EnterTree(){
			base._EnterTree();
				this.Menu = GetChild<MainMenu>(0);
				this.Menu.Visible = false;
			}
		public override void _Ready(){
				}
		public override void _Input(InputEvent @event){
			base._Input(@event);
			if (@event is InputEventKey _keyEscape){
				if (_keyEscape.IsPressed() && _keyEscape.Keycode == Key.Escape){
					if (this.Menu.Visible == false){
						this.Menu.Show();
						}
					else{
						this.Menu.Visible = false;
						}
					}
				}
			}
		}
