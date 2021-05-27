void LightDirection_half(out half3 Direction, out half Distance, out half3 LightColor){
#if SHADERGRAPH_PREVIEW
	Direction = half3(0,1,0);
	Distance = 1;
	LightColor = half3(1,1,1);
#else
	Light light = GetMainLight();
	Direction = normalize(light.direction);
	Distance = light.distanceAttenuation;
	LightColor = light.color;
#endif
}