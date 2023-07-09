using Godot;

public partial class Player : CharacterBody2D{
	[Export]
		float Speed = 0.0f;
	private static Vector2 GetMovementInput(Vector2 input){
		Vector2 _targetInput;
		float _horizontal = Input.GetActionStrength("ui_right") - Input.GetActionStrength("ui_left");
		float _vertival = Input.GetActionStrength("ui_down") - Input.GetActionStrength("ui_up");
			_targetInput = new Vector2(_horizontal, _vertival);
		return _targetInput.Normalized();
		}
	public override void _PhysicsProcess(double delta){
		Velocity = GetMovementInput(Velocity) * Speed;
		MoveAndSlide();
		}
	}
