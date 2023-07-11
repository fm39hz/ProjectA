using Godot;
using ProjectA.Script.Interface;

namespace ProjectA.System.UI;
	public partial class UIController : Control{
		private MainMenu Menu { get; set; }
		public override void _EnterTree(){
			base._EnterTree();
				this.Menu = GetParent().GetChild<MainMenu>(1);
				this.Menu.Visible = false;
			}
		public override void _Ready(){
				}
		public override void _Input(InputEvent @event){
			base._Input(@event);
			if (@event is InputEventKey _keyEscape){
				if (_keyEscape.IsPressed() && _keyEscape.Keycode == Key.Escape){
					if (this.Menu.Visible == false){
						GetTree().Paused = true;
						this.Menu.Show();
						}
					else{
						this.Menu.Visible = false;
						GetTree().Paused = false;
						}
					}
				}
			}
		}
