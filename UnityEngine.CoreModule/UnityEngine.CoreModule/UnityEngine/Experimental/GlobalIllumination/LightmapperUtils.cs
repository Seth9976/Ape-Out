using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination
{
	// Token: 0x020001A0 RID: 416
	public static class LightmapperUtils : Object
	{
		// Token: 0x06001EF3 RID: 7923 RVA: 0x000720CC File Offset: 0x000702CC
		// Note: this type is marked as 'beforefieldinit'.
		static LightmapperUtils()
		{
			Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LightmapperUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100666129);
			LightmapperUtils.NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100666130);
			LightmapperUtils.NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100666131);
			LightmapperUtils.NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100666132);
			LightmapperUtils.NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100666133);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100666134);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100666135);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100666136);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100666137);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100666138);
			LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapperUtils>.NativeClassPtr, 100666139);
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x000721D8 File Offset: 0x000703D8
		[CallerCount(0)]
		public unsafe static LightMode Extract(LightmapBakeType baketype)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref baketype;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EF5 RID: 7925 RVA: 0x00072218 File Offset: 0x00070418
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 504496, RefRangeEnd = 504501, XrefRangeStart = 504489, XrefRangeEnd = 504496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LinearColor ExtractIndirect(Light l)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x0007225C File Offset: 0x0007045C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504501, XrefRangeEnd = 504505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ExtractInnerCone(Light l)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x000722A0 File Offset: 0x000704A0
		[CallerCount(0)]
		public unsafe static Color ExtractColorTemperature(Light l)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x000722E4 File Offset: 0x000704E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504505, XrefRangeEnd = 504508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ApplyColorTemperature(Color cct, ref LinearColor lightColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cct;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lightColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00072324 File Offset: 0x00070524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504533, RefRangeEnd = 504534, XrefRangeStart = 504508, XrefRangeEnd = 504533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref DirectionalLight dir)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x00072368 File Offset: 0x00070568
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 504561, RefRangeEnd = 504563, XrefRangeStart = 504534, XrefRangeEnd = 504561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref PointLight point)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x000723AC File Offset: 0x000705AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504596, RefRangeEnd = 504597, XrefRangeStart = 504563, XrefRangeEnd = 504596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref SpotLight spot)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &spot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x000723F0 File Offset: 0x000705F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504624, RefRangeEnd = 504625, XrefRangeStart = 504597, XrefRangeEnd = 504624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref RectangleLight rect)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00072434 File Offset: 0x00070634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 504561, RefRangeEnd = 504563, XrefRangeStart = 504561, XrefRangeEnd = 504563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, ref DiscLight disc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &disc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x00072478 File Offset: 0x00070678
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 504647, RefRangeEnd = 504652, XrefRangeStart = 504625, XrefRangeEnd = 504647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Extract(Light l, out Cookie cookie)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(l);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightmapperUtils.NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00010179 File Offset: 0x0000E379
		public LightmapperUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_LightMode_LightmapBakeType_0;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeMethodInfoPtr_ExtractIndirect_Public_Static_LinearColor_Light_0;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeMethodInfoPtr_ExtractInnerCone_Public_Static_Single_Light_0;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeMethodInfoPtr_ExtractColorTemperature_Private_Static_Color_Light_0;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColorTemperature_Private_Static_Void_Color_byref_LinearColor_0;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DirectionalLight_0;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_PointLight_0;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_SpotLight_0;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_RectangleLight_0;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_DiscLight_0;

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeMethodInfoPtr_Extract_Public_Static_Void_Light_byref_Cookie_0;
	}
}
