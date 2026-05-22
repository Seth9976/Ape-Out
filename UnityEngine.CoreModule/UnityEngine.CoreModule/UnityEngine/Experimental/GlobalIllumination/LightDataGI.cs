using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x0200019F RID: 415
	[StructLayout(2)]
	public struct LightDataGI
	{
		// Token: 0x06001EE6 RID: 7910 RVA: 0x00071CD0 File Offset: 0x0006FED0
		// Note: this type is marked as 'beforefieldinit'.
		static LightDataGI()
		{
			Il2CppClassPointerStore<LightDataGI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LightDataGI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr);
			LightDataGI.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "instanceID");
			LightDataGI.NativeFieldInfoPtr_cookieID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "cookieID");
			LightDataGI.NativeFieldInfoPtr_cookieScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "cookieScale");
			LightDataGI.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "color");
			LightDataGI.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "indirectColor");
			LightDataGI.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "orientation");
			LightDataGI.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "position");
			LightDataGI.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "range");
			LightDataGI.NativeFieldInfoPtr_coneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "coneAngle");
			LightDataGI.NativeFieldInfoPtr_innerConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "innerConeAngle");
			LightDataGI.NativeFieldInfoPtr_shape0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shape0");
			LightDataGI.NativeFieldInfoPtr_shape1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shape1");
			LightDataGI.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "type");
			LightDataGI.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "mode");
			LightDataGI.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shadow");
			LightDataGI.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "falloff");
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100666123);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100666124);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100666125);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100666126);
			LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100666127);
			LightDataGI.NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100666128);
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00071EB8 File Offset: 0x000700B8
		[CallerCount(0)]
		public unsafe void Init(ref DirectionalLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00071EF8 File Offset: 0x000700F8
		[CallerCount(0)]
		public unsafe void Init(ref PointLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00071F38 File Offset: 0x00070138
		[CallerCount(0)]
		public unsafe void Init(ref SpotLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00071F78 File Offset: 0x00070178
		[CallerCount(0)]
		public unsafe void Init(ref RectangleLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x00071FB8 File Offset: 0x000701B8
		[CallerCount(0)]
		public unsafe void Init(ref DiscLight light, ref Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &light;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x00071FF8 File Offset: 0x000701F8
		[CallerCount(0)]
		public unsafe void InitNoBake(int lightInstanceID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lightInstanceID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDataGI.NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x00010167 File Offset: 0x0000E367
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, ref this));
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x0007202C File Offset: 0x0007022C
		public void Init(ref DirectionalLight light)
		{
			Cookie cookie = Cookie.Defaults();
			this.Init(ref light, ref cookie);
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x0007204C File Offset: 0x0007024C
		public void Init(ref PointLight light)
		{
			Cookie cookie = Cookie.Defaults();
			this.Init(ref light, ref cookie);
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x0007206C File Offset: 0x0007026C
		public void Init(ref SpotLight light)
		{
			Cookie cookie = Cookie.Defaults();
			this.Init(ref light, ref cookie);
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x0007208C File Offset: 0x0007028C
		public void Init(ref RectangleLight light)
		{
			Cookie cookie = Cookie.Defaults();
			this.Init(ref light, ref cookie);
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x000720AC File Offset: 0x000702AC
		public void Init(ref DiscLight light)
		{
			Cookie cookie = Cookie.Defaults();
			this.Init(ref light, ref cookie);
		}

		// Token: 0x0400184A RID: 6218
		private static readonly IntPtr NativeFieldInfoPtr_instanceID;

		// Token: 0x0400184B RID: 6219
		private static readonly IntPtr NativeFieldInfoPtr_cookieID;

		// Token: 0x0400184C RID: 6220
		private static readonly IntPtr NativeFieldInfoPtr_cookieScale;

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeFieldInfoPtr_indirectColor;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeFieldInfoPtr_orientation;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeFieldInfoPtr_coneAngle;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeFieldInfoPtr_innerConeAngle;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeFieldInfoPtr_shape0;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeFieldInfoPtr_shape1;

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeFieldInfoPtr_shadow;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeFieldInfoPtr_falloff;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0;

		// Token: 0x04001860 RID: 6240
		[FieldOffset(0)]
		public int instanceID;

		// Token: 0x04001861 RID: 6241
		[FieldOffset(4)]
		public int cookieID;

		// Token: 0x04001862 RID: 6242
		[FieldOffset(8)]
		public float cookieScale;

		// Token: 0x04001863 RID: 6243
		[FieldOffset(12)]
		public LinearColor color;

		// Token: 0x04001864 RID: 6244
		[FieldOffset(28)]
		public LinearColor indirectColor;

		// Token: 0x04001865 RID: 6245
		[FieldOffset(44)]
		public Quaternion orientation;

		// Token: 0x04001866 RID: 6246
		[FieldOffset(60)]
		public Vector3 position;

		// Token: 0x04001867 RID: 6247
		[FieldOffset(72)]
		public float range;

		// Token: 0x04001868 RID: 6248
		[FieldOffset(76)]
		public float coneAngle;

		// Token: 0x04001869 RID: 6249
		[FieldOffset(80)]
		public float innerConeAngle;

		// Token: 0x0400186A RID: 6250
		[FieldOffset(84)]
		public float shape0;

		// Token: 0x0400186B RID: 6251
		[FieldOffset(88)]
		public float shape1;

		// Token: 0x0400186C RID: 6252
		[FieldOffset(92)]
		public LightType type;

		// Token: 0x0400186D RID: 6253
		[FieldOffset(93)]
		public LightMode mode;

		// Token: 0x0400186E RID: 6254
		[FieldOffset(94)]
		public byte shadow;

		// Token: 0x0400186F RID: 6255
		[FieldOffset(95)]
		public FalloffType falloff;
	}
}
