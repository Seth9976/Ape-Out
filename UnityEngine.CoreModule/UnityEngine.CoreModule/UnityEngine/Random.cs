using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000BC RID: 188
	public static class Random : Object
	{
		// Token: 0x060011B1 RID: 4529 RVA: 0x00048B6C File Offset: 0x00046D6C
		// Note: this type is marked as 'beforefieldinit'.
		static Random()
		{
			Il2CppClassPointerStore<Random>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Random");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random>.NativeClassPtr);
			Random.NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100664763);
			Random.NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100664764);
			Random.NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100664765);
			Random.NativeMethodInfoPtr_get_value_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100664766);
			Random.NativeMethodInfoPtr_GetRandomUnitCircle_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100664767);
			Random.NativeMethodInfoPtr_get_insideUnitCircle_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100664768);
			Random.NativeMethodInfoPtr_get_onUnitSphere_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100664769);
			Random.NativeMethodInfoPtr_get_onUnitSphere_Injected_Private_Static_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100664770);
			Random.InitStateDelegateField = IL2CPP.ResolveICall<Random.InitStateDelegate>("UnityEngine.Random::InitState");
			Random.get_seedDelegateField = IL2CPP.ResolveICall<Random.get_seedDelegate>("UnityEngine.Random::get_seed");
			Random.set_seedDelegateField = IL2CPP.ResolveICall<Random.set_seedDelegate>("UnityEngine.Random::set_seed");
			Random.get_insideUnitSphere_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_insideUnitSphere_InjectedDelegate>("UnityEngine.Random::get_insideUnitSphere_Injected");
			Random.get_rotation_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_rotation_InjectedDelegate>("UnityEngine.Random::get_rotation_Injected");
			Random.get_rotationUniform_InjectedDelegateField = IL2CPP.ResolveICall<Random.get_rotationUniform_InjectedDelegate>("UnityEngine.Random::get_rotationUniform_Injected");
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00048C98 File Offset: 0x00046E98
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 493675, RefRangeEnd = 493733, XrefRangeStart = 493671, XrefRangeEnd = 493675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Range(float minInclusive, float maxInclusive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxInclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00048CE4 File Offset: 0x00046EE4
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 493737, RefRangeEnd = 493764, XrefRangeStart = 493733, XrefRangeEnd = 493737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Range(int minInclusive, int maxExclusive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxExclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00048D30 File Offset: 0x00046F30
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 493737, RefRangeEnd = 493764, XrefRangeStart = 493737, XrefRangeEnd = 493764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RandomRangeInt(int minInclusive, int maxExclusive)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minInclusive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxExclusive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x00048D7C File Offset: 0x00046F7C
		public unsafe static float value
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 493768, RefRangeEnd = 493774, XrefRangeStart = 493764, XrefRangeEnd = 493768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_value_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00048DAC File Offset: 0x00046FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493774, XrefRangeEnd = 493778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRandomUnitCircle(out Vector2 output)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &output;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_GetRandomUnitCircle_Private_Static_Void_byref_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x00048DE0 File Offset: 0x00046FE0
		public unsafe static Vector2 insideUnitCircle
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 493780, RefRangeEnd = 493785, XrefRangeStart = 493778, XrefRangeEnd = 493780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_insideUnitCircle_Public_Static_get_Vector2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x00048E10 File Offset: 0x00047010
		public unsafe static Vector3 onUnitSphere
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493785, XrefRangeEnd = 493787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_onUnitSphere_Public_Static_get_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00048E40 File Offset: 0x00047040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493787, XrefRangeEnd = 493791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_onUnitSphere_Injected(out Vector3 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Random.NativeMethodInfoPtr_get_onUnitSphere_Injected_Private_Static_Void_byref_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x0000A560 File Offset: 0x00008760
		public Random(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0000A569 File Offset: 0x00008769
		public static void InitState(int seed)
		{
			Random.InitStateDelegateField(seed);
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x00048E74 File Offset: 0x00047074
		public static Vector3 insideUnitSphere
		{
			get
			{
				Vector3 vector;
				Random.get_insideUnitSphere_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x00048E8C File Offset: 0x0004708C
		public static Quaternion rotation
		{
			get
			{
				Quaternion quaternion;
				Random.get_rotation_Injected(out quaternion);
				return quaternion;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x00048EA4 File Offset: 0x000470A4
		public static Quaternion rotationUniform
		{
			get
			{
				Quaternion quaternion;
				Random.get_rotationUniform_Injected(out quaternion);
				return quaternion;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x0000A576 File Offset: 0x00008776
		// (set) Token: 0x060011C0 RID: 4544 RVA: 0x0000A582 File Offset: 0x00008782
		public static int seed
		{
			get
			{
				return Random.get_seedDelegateField();
			}
			set
			{
				Random.set_seedDelegateField(value);
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00048EBC File Offset: 0x000470BC
		public static float RandomRange(float min, float max)
		{
			return Random.Range(min, max);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00048ED8 File Offset: 0x000470D8
		public static int RandomRange(int min, int max)
		{
			return Random.Range(min, max);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00048EF4 File Offset: 0x000470F4
		public static Color ColorHSV()
		{
			return Random.ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 1f, 1f);
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00048F34 File Offset: 0x00047134
		public static Color ColorHSV(float hueMin, float hueMax)
		{
			return Random.ColorHSV(hueMin, hueMax, 0f, 1f, 0f, 1f, 1f, 1f);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00048F6C File Offset: 0x0004716C
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax)
		{
			return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, 0f, 1f, 1f, 1f);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00048F9C File Offset: 0x0004719C
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax)
		{
			return Random.ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax, 1f, 1f);
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00048FC8 File Offset: 0x000471C8
		public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax)
		{
			float num = Mathf.Lerp(hueMin, hueMax, Random.value);
			float num2 = Mathf.Lerp(saturationMin, saturationMax, Random.value);
			float num3 = Mathf.Lerp(valueMin, valueMax, Random.value);
			Color color = Color.HSVToRGB(num, num2, num3, true);
			color.a = Mathf.Lerp(alphaMin, alphaMax, Random.value);
			return color;
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0000A58F File Offset: 0x0000878F
		public static void get_insideUnitSphere_Injected(out Vector3 ret)
		{
			Random.get_insideUnitSphere_InjectedDelegateField(out ret);
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0000A59C File Offset: 0x0000879C
		public static void get_rotation_Injected(out Quaternion ret)
		{
			Random.get_rotation_InjectedDelegateField(out ret);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0000A5A9 File Offset: 0x000087A9
		public static void get_rotationUniform_Injected(out Quaternion ret)
		{
			Random.get_rotationUniform_InjectedDelegateField(out ret);
		}

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Static_get_Single_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomUnitCircle_Private_Static_Void_byref_Vector2_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_get_insideUnitCircle_Public_Static_get_Vector2_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_get_onUnitSphere_Public_Static_get_Vector3_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_get_onUnitSphere_Injected_Private_Static_Void_byref_Vector3_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly Random.InitStateDelegate InitStateDelegateField;

		// Token: 0x04000E63 RID: 3683
		private static readonly Random.get_seedDelegate get_seedDelegateField;

		// Token: 0x04000E64 RID: 3684
		private static readonly Random.set_seedDelegate set_seedDelegateField;

		// Token: 0x04000E65 RID: 3685
		private static readonly Random.get_insideUnitSphere_InjectedDelegate get_insideUnitSphere_InjectedDelegateField;

		// Token: 0x04000E66 RID: 3686
		private static readonly Random.get_rotation_InjectedDelegate get_rotation_InjectedDelegateField;

		// Token: 0x04000E67 RID: 3687
		private static readonly Random.get_rotationUniform_InjectedDelegate get_rotationUniform_InjectedDelegateField;

		// Token: 0x02000779 RID: 1913
		// (Invoke) Token: 0x06002D0D RID: 11533
		private delegate void InitStateDelegate(int seed);

		// Token: 0x0200077A RID: 1914
		// (Invoke) Token: 0x06002D0F RID: 11535
		private delegate int get_seedDelegate();

		// Token: 0x0200077B RID: 1915
		// (Invoke) Token: 0x06002D11 RID: 11537
		private delegate void set_seedDelegate(int value);

		// Token: 0x0200077C RID: 1916
		// (Invoke) Token: 0x06002D13 RID: 11539
		private delegate void get_insideUnitSphere_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200077D RID: 1917
		// (Invoke) Token: 0x06002D15 RID: 11541
		private delegate void get_rotation_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x0200077E RID: 1918
		// (Invoke) Token: 0x06002D17 RID: 11543
		private delegate void get_rotationUniform_InjectedDelegate([Out] IntPtr ret);
	}
}
