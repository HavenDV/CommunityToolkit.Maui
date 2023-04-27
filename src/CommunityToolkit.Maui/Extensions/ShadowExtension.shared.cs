namespace CommunityToolkit.Maui.Extensions;

/// <inheritdoc />
public class ShadowExtension : IMarkupExtension<Shadow>
{
	/// <summary>
	/// Default value: 10.0f.
	/// </summary>
	public float Radius { get; set; } = 10.0f;
	
	/// <summary>
	/// Default value: 1.0f.
	/// </summary>
	public float Opacity { get; set; } = 1.0f;
	
	/// <summary>
	/// Default value: Brush.Black.
	/// </summary>
	public Brush Brush { get; set; } = Brush.Black;
	
	/// <summary>
	/// Default value: 10, 10.
	/// </summary>
	public Point Offset { get; set; } = new(x: 10, y: 10);
	
	/// <inheritdoc />
	public Shadow ProvideValue(IServiceProvider serviceProvider)
	{
		return new Shadow
		{
			Radius = Radius,
			Opacity = Opacity,
			Brush = Brush,
			Offset = Offset,
		};
	}

	/// <inheritdoc />
	object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
	{
		return ProvideValue(serviceProvider);
	}
}