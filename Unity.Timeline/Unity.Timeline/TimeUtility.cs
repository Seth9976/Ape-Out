using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Timeline
{
	// Token: 0x0200004D RID: 77
	public static class TimeUtility : Object
	{
		// Token: 0x06000503 RID: 1283 RVA: 0x000183B0 File Offset: 0x000165B0
		// Note: this type is marked as 'beforefieldinit'.
		static TimeUtility()
		{
			Il2CppClassPointerStore<TimeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimeUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr);
			TimeUtility.NativeFieldInfoPtr_kTimeEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, "kTimeEpsilon");
			TimeUtility.NativeFieldInfoPtr_kFrameRateEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, "kFrameRateEpsilon");
			TimeUtility.NativeFieldInfoPtr_k_MaxTimelineDurationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, "k_MaxTimelineDurationInSeconds");
			TimeUtility.NativeMethodInfoPtr_ValidateFrameRate_Private_Static_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664120);
			TimeUtility.NativeMethodInfoPtr_ToFrames_Public_Static_Int32_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664121);
			TimeUtility.NativeMethodInfoPtr_ToExactFrames_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664122);
			TimeUtility.NativeMethodInfoPtr_FromFrames_Public_Static_Double_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664123);
			TimeUtility.NativeMethodInfoPtr_FromFrames_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664124);
			TimeUtility.NativeMethodInfoPtr_OnFrameBoundary_Public_Static_Boolean_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664125);
			TimeUtility.NativeMethodInfoPtr_GetEpsilon_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664126);
			TimeUtility.NativeMethodInfoPtr_OnFrameBoundary_Public_Static_Boolean_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664127);
			TimeUtility.NativeMethodInfoPtr_RoundToFrame_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664128);
			TimeUtility.NativeMethodInfoPtr_TimeAsFrames_Public_Static_String_Double_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664129);
			TimeUtility.NativeMethodInfoPtr_TimeAsTimeCode_Public_Static_String_Double_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664130);
			TimeUtility.NativeMethodInfoPtr_ParseTimeCode_Public_Static_Double_String_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664131);
			TimeUtility.NativeMethodInfoPtr_GetAnimationClipLength_Public_Static_Double_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664132);
			TimeUtility.NativeMethodInfoPtr_RemoveChar_Private_Static_String_String_Func_2_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664133);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00018534 File Offset: 0x00016734
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 479845, RefRangeEnd = 479853, XrefRangeStart = 479841, XrefRangeEnd = 479845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateFrameRate(double frameRate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref frameRate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.NativeMethodInfoPtr_ValidateFrameRate_Private_Static_Void_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00018568 File Offset: 0x00016768
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 479871, RefRangeEnd = 479874, XrefRangeStart = 479853, XrefRangeEnd = 479871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToFrames(double time, double frameRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.NativeMethodInfoPtr_ToFrames_Public_Static_Int32_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000185B4 File Offset: 0x000167B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 479878, RefRangeEnd = 479882, XrefRangeStart = 479874, XrefRangeEnd = 479878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ToExactFrames(double time, double frameRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.NativeMethodInfoPtr_ToExactFrames_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00018600 File Offset: 0x00016800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479882, XrefRangeEnd = 479886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double FromFrames(int frames, double frameRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref frames;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.NativeMethodInfoPtr_FromFrames_Public_Static_Double_Int32_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0001864C File Offset: 0x0001684C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479886, XrefRangeEnd = 479890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double FromFrames(double frames, double frameRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref frames;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.NativeMethodInfoPtr_FromFrames_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00018698 File Offset: 0x00016898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479903, RefRangeEnd = 479905, XrefRangeStart = 479890, XrefRangeEnd = 479903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool OnFrameBoundary(double time, double frameRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.NativeMethodInfoPtr_OnFrameBoundary_Public_Static_Boolean_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000186E4 File Offset: 0x000168E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479913, RefRangeEnd = 479915, XrefRangeStart = 479905, XrefRangeEnd = 479913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetEpsilon(double time, double frameRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.NativeMethodInfoPtr_GetEpsilon_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00018730 File Offset: 0x00016930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479915, XrefRangeEnd = 479924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool OnFrameBoundary(double time, double frameRate, double epsilon)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameRate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref epsilon;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.NativeMethodInfoPtr_OnFrameBoundary_Public_Static_Boolean_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0001878C File Offset: 0x0001698C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479924, XrefRangeEnd = 479933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double RoundToFrame(double time, double frameRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.NativeMethodInfoPtr_RoundToFrame_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000187D8 File Offset: 0x000169D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479933, XrefRangeEnd = 479946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TimeAsFrames(double timeValue, double frameRate, string format = "F2")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameRate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.NativeMethodInfoPtr_TimeAsFrames_Public_Static_String_Double_Double_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00018830 File Offset: 0x00016A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479946, XrefRangeEnd = 480022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TimeAsTimeCode(double timeValue, double frameRate, string format = "F2")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameRate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.NativeMethodInfoPtr_TimeAsTimeCode_Public_Static_String_Double_Double_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00018888 File Offset: 0x00016A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480022, XrefRangeEnd = 480096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ParseTimeCode(string timeCode, double frameRate, double defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(timeCode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frameRate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.NativeMethodInfoPtr_ParseTimeCode_Public_Static_Double_String_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000188E8 File Offset: 0x00016AE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 480118, RefRangeEnd = 480121, XrefRangeStart = 480096, XrefRangeEnd = 480118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double GetAnimationClipLength(AnimationClip clip)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.NativeMethodInfoPtr_GetAnimationClipLength_Public_Static_Double_AnimationClip_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001892C File Offset: 0x00016B2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 480126, RefRangeEnd = 480128, XrefRangeStart = 480121, XrefRangeEnd = 480126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RemoveChar(string str, Func<char, bool> charToRemoveFunc)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(charToRemoveFunc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.NativeMethodInfoPtr_RemoveChar_Private_Static_String_String_Func_2_Char_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00003AA6 File Offset: 0x00001CA6
		public TimeUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0001897C File Offset: 0x00016B7C
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00003AAF File Offset: 0x00001CAF
		public unsafe static double kTimeEpsilon
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimeUtility.NativeFieldInfoPtr_kTimeEpsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeUtility.NativeFieldInfoPtr_kTimeEpsilon, (void*)(&value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00018998 File Offset: 0x00016B98
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00003ABD File Offset: 0x00001CBD
		public unsafe static double kFrameRateEpsilon
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimeUtility.NativeFieldInfoPtr_kFrameRateEpsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeUtility.NativeFieldInfoPtr_kFrameRateEpsilon, (void*)(&value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x000189B4 File Offset: 0x00016BB4
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00003ACB File Offset: 0x00001CCB
		public unsafe static double k_MaxTimelineDurationInSeconds
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimeUtility.NativeFieldInfoPtr_k_MaxTimelineDurationInSeconds, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeUtility.NativeFieldInfoPtr_k_MaxTimelineDurationInSeconds, (void*)(&value));
			}
		}

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_kTimeEpsilon;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_kFrameRateEpsilon;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxTimelineDurationInSeconds;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_ValidateFrameRate_Private_Static_Void_Double_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_ToFrames_Public_Static_Int32_Double_Double_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_ToExactFrames_Public_Static_Double_Double_Double_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_FromFrames_Public_Static_Double_Int32_Double_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_FromFrames_Public_Static_Double_Double_Double_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_OnFrameBoundary_Public_Static_Boolean_Double_Double_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_GetEpsilon_Public_Static_Double_Double_Double_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_OnFrameBoundary_Public_Static_Boolean_Double_Double_Double_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_RoundToFrame_Public_Static_Double_Double_Double_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_TimeAsFrames_Public_Static_String_Double_Double_String_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_TimeAsTimeCode_Public_Static_String_Double_Double_String_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_ParseTimeCode_Public_Static_Double_String_Double_Double_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimationClipLength_Public_Static_Double_AnimationClip_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChar_Private_Static_String_String_Func_2_Char_Boolean_0;

		// Token: 0x0200007B RID: 123
		[ObfuscatedName("UnityEngine.Timeline.TimeUtility+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000624 RID: 1572 RVA: 0x0001BDE8 File Offset: 0x00019FE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TimeUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUtility.__c>.NativeClassPtr);
				TimeUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUtility.__c>.NativeClassPtr, "<>9");
				TimeUtility.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUtility.__c>.NativeClassPtr, "<>9__14_0");
				TimeUtility.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUtility.__c>.NativeClassPtr, "<>9__14_1");
				TimeUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility.__c>.NativeClassPtr, 100664136);
				TimeUtility.__c.NativeMethodInfoPtr__ParseTimeCode_b__14_0_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility.__c>.NativeClassPtr, 100664137);
				TimeUtility.__c.NativeMethodInfoPtr__ParseTimeCode_b__14_1_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility.__c>.NativeClassPtr, 100664138);
			}

			// Token: 0x06000625 RID: 1573 RVA: 0x0001BE8C File Offset: 0x0001A08C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000626 RID: 1574 RVA: 0x0001BEC8 File Offset: 0x0001A0C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479837, XrefRangeEnd = 479841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ParseTimeCode_b__14_0(char c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref c;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.__c.NativeMethodInfoPtr__ParseTimeCode_b__14_0_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000627 RID: 1575 RVA: 0x0001BF14 File Offset: 0x0001A114
			[CallerCount(0)]
			public unsafe bool _ParseTimeCode_b__14_1(char c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref c;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtility.__c.NativeMethodInfoPtr__ParseTimeCode_b__14_1_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000628 RID: 1576 RVA: 0x000042FB File Offset: 0x000024FB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001DD RID: 477
			// (get) Token: 0x06000629 RID: 1577 RVA: 0x0001BF60 File Offset: 0x0001A160
			// (set) Token: 0x0600062A RID: 1578 RVA: 0x00004304 File Offset: 0x00002504
			public unsafe static TimeUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DE RID: 478
			// (get) Token: 0x0600062B RID: 1579 RVA: 0x0001BF88 File Offset: 0x0001A188
			// (set) Token: 0x0600062C RID: 1580 RVA: 0x00004316 File Offset: 0x00002516
			public unsafe static Func<char, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeUtility.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<char, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeUtility.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001DF RID: 479
			// (get) Token: 0x0600062D RID: 1581 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
			// (set) Token: 0x0600062E RID: 1582 RVA: 0x00004328 File Offset: 0x00002528
			public unsafe static Func<char, bool> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TimeUtility.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<char, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TimeUtility.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004C2 RID: 1218
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040004C3 RID: 1219
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x040004C4 RID: 1220
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x040004C5 RID: 1221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004C6 RID: 1222
			private static readonly IntPtr NativeMethodInfoPtr__ParseTimeCode_b__14_0_Internal_Boolean_Char_0;

			// Token: 0x040004C7 RID: 1223
			private static readonly IntPtr NativeMethodInfoPtr__ParseTimeCode_b__14_1_Internal_Boolean_Char_0;
		}
	}
}
