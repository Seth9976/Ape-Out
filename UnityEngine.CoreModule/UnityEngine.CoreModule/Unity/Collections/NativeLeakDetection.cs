using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections
{
	// Token: 0x02000025 RID: 37
	public static class NativeLeakDetection : Object
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x000171C8 File Offset: 0x000153C8
		// Note: this type is marked as 'beforefieldinit'.
		static NativeLeakDetection()
		{
			Il2CppClassPointerStore<NativeLeakDetection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeLeakDetection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeLeakDetection>.NativeClassPtr);
			NativeLeakDetection.NativeFieldInfoPtr_s_NativeLeakDetectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeLeakDetection>.NativeClassPtr, "s_NativeLeakDetectionMode");
			NativeLeakDetection.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeLeakDetection>.NativeClassPtr, 100663347);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00017220 File Offset: 0x00015420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 485830, XrefRangeEnd = 485832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeLeakDetection.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002AF4 File Offset: 0x00000CF4
		public NativeLeakDetection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00017248 File Offset: 0x00015448
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002AFD File Offset: 0x00000CFD
		public unsafe static int s_NativeLeakDetectionMode
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(NativeLeakDetection.NativeFieldInfoPtr_s_NativeLeakDetectionMode, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeLeakDetection.NativeFieldInfoPtr_s_NativeLeakDetectionMode, (void*)(&value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00017264 File Offset: 0x00015464
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00017290 File Offset: 0x00015490
		public static NativeLeakDetectionMode Mode
		{
			get
			{
				bool flag = NativeLeakDetection.s_NativeLeakDetectionMode == 0;
				if (flag)
				{
					NativeLeakDetection.Initialize();
				}
				return (NativeLeakDetectionMode)NativeLeakDetection.s_NativeLeakDetectionMode;
			}
			set
			{
				bool flag = NativeLeakDetection.s_NativeLeakDetectionMode != (int)value;
				if (flag)
				{
					NativeLeakDetection.s_NativeLeakDetectionMode = (int)value;
				}
			}
		}

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr_s_NativeLeakDetectionMode;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;

		// Token: 0x040000C4 RID: 196
		public const string kNativeLeakDetectionModePrefsString = "Unity.Colletions.NativeLeakDetection.Mode";
	}
}
