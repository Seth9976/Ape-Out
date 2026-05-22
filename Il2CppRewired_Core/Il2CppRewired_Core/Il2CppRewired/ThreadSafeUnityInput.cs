using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppRewired
{
	// Token: 0x02000032 RID: 50
	public static class ThreadSafeUnityInput : global::Il2CppSystem.Object
	{
		// Token: 0x060003AF RID: 943 RVA: 0x0003BF9C File Offset: 0x0003A19C
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadSafeUnityInput()
		{
			Il2CppClassPointerStore<ThreadSafeUnityInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ThreadSafeUnityInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadSafeUnityInput>.NativeClassPtr);
			ThreadSafeUnityInput.NativeFieldInfoPtr_lgvnBGxsNLSQYrriqKGgQpFDCAp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput>.NativeClassPtr, "lgvnBGxsNLSQYrriqKGgQpFDCAp");
			ThreadSafeUnityInput.NativeFieldInfoPtr_WSzTlWJlPCQyyHjCTEBkwngvbacK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput>.NativeClassPtr, "WSzTlWJlPCQyyHjCTEBkwngvbacK");
			ThreadSafeUnityInput.NativeMethodInfoPtr_get_mouse_Public_Static_get_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput>.NativeClassPtr, 100663900);
			ThreadSafeUnityInput.NativeMethodInfoPtr_get_keyboard_Public_Static_get_Keyboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput>.NativeClassPtr, 100663901);
			ThreadSafeUnityInput.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput>.NativeClassPtr, 100663902);
			ThreadSafeUnityInput.NativeMethodInfoPtr_PostInitialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput>.NativeClassPtr, 100663903);
			ThreadSafeUnityInput.NativeMethodInfoPtr_PostInitialize2_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput>.NativeClassPtr, 100663904);
			ThreadSafeUnityInput.NativeMethodInfoPtr_Deinitialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput>.NativeClassPtr, 100663905);
			ThreadSafeUnityInput.NativeMethodInfoPtr_Update_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput>.NativeClassPtr, 100663906);
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0003C080 File Offset: 0x0003A280
		public unsafe static ThreadSafeUnityInput.Mouse mouse
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 244908, RefRangeEnd = 244916, XrefRangeStart = 244894, XrefRangeEnd = 244908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.NativeMethodInfoPtr_get_mouse_Public_Static_get_Mouse_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThreadSafeUnityInput.Mouse>(intPtr3) : null;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0003C0B4 File Offset: 0x0003A2B4
		public unsafe static ThreadSafeUnityInput.Keyboard keyboard
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 244923, RefRangeEnd = 244928, XrefRangeStart = 244916, XrefRangeEnd = 244923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.NativeMethodInfoPtr_get_keyboard_Public_Static_get_Keyboard_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ThreadSafeUnityInput.Keyboard>(intPtr3) : null;
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0003C0E8 File Offset: 0x0003A2E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0003C110 File Offset: 0x0003A310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244928, XrefRangeEnd = 244933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PostInitialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.NativeMethodInfoPtr_PostInitialize_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0003C138 File Offset: 0x0003A338
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PostInitialize2()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.NativeMethodInfoPtr_PostInitialize2_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0003C160 File Offset: 0x0003A360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244933, XrefRangeEnd = 244936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Deinitialize()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.NativeMethodInfoPtr_Deinitialize_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0003C188 File Offset: 0x0003A388
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244951, RefRangeEnd = 244952, XrefRangeStart = 244936, XrefRangeEnd = 244951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Update()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.NativeMethodInfoPtr_Update_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000032C9 File Offset: 0x000014C9
		public ThreadSafeUnityInput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0003C1B0 File Offset: 0x0003A3B0
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x000032D2 File Offset: 0x000014D2
		public unsafe static ThreadSafeUnityInput.Mouse lgvnBGxsNLSQYrriqKGgQpFDCAp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadSafeUnityInput.NativeFieldInfoPtr_lgvnBGxsNLSQYrriqKGgQpFDCAp, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadSafeUnityInput.Mouse>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadSafeUnityInput.NativeFieldInfoPtr_lgvnBGxsNLSQYrriqKGgQpFDCAp, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0003C1D8 File Offset: 0x0003A3D8
		// (set) Token: 0x060003BB RID: 955 RVA: 0x000032E4 File Offset: 0x000014E4
		public unsafe static ThreadSafeUnityInput.Keyboard WSzTlWJlPCQyyHjCTEBkwngvbacK
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadSafeUnityInput.NativeFieldInfoPtr_WSzTlWJlPCQyyHjCTEBkwngvbacK, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadSafeUnityInput.Keyboard>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadSafeUnityInput.NativeFieldInfoPtr_WSzTlWJlPCQyyHjCTEBkwngvbacK, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeFieldInfoPtr_lgvnBGxsNLSQYrriqKGgQpFDCAp;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeFieldInfoPtr_WSzTlWJlPCQyyHjCTEBkwngvbacK;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_get_mouse_Public_Static_get_Mouse_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_get_keyboard_Public_Static_get_Keyboard_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_PostInitialize_Public_Static_Void_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_PostInitialize2_Public_Static_Void_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_Deinitialize_Public_Static_Void_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_0;

		// Token: 0x02000236 RID: 566
		public sealed class Keyboard : global::Il2CppSystem.Object
		{
			// Token: 0x06003836 RID: 14390 RVA: 0x0011413C File Offset: 0x0011233C
			// Note: this type is marked as 'beforefieldinit'.
			static Keyboard()
			{
				Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadSafeUnityInput>.NativeClassPtr, "Keyboard");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_MXvdFwIPBexhyMATfJEjXZJJhWG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "MXvdFwIPBexhyMATfJEjXZJJhWG");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_Escape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "keyValueIndex_Escape");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_Menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "keyValueIndex_Menu");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_F2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "keyValueIndex_F2");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_UpArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "keyValueIndex_UpArrow");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_RightArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "keyValueIndex_RightArrow");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_DownArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "keyValueIndex_DownArrow");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_LeftArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "keyValueIndex_LeftArrow");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_vWEqvAByfIJzuerfCHjyPjbltGf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "vWEqvAByfIJzuerfCHjyPjbltGf");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_wSOrwFBNHJCgwHpdCNaWBdHhEjOI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "wSOrwFBNHJCgwHpdCNaWBdHhEjOI");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_iGppYSmdCQQOOAuolPgqgTBkCRm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "iGppYSmdCQQOOAuolPgqgTBkCRm");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_yMWHcoZgVBayuPKzlxlxgqwAhpR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "yMWHcoZgVBayuPKzlxlxgqwAhpR");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "kOIBhhDgDUQCZtioVlUwqEtbkMdb");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_eGfSoiZNGPyXfKQRmWaRNSIUcct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "eGfSoiZNGPyXfKQRmWaRNSIUcct");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_evYjOreRqjMHReoKHTuuAprqbVL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "evYjOreRqjMHReoKHTuuAprqbVL");
				ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_ccLWvvtHgtajoCYxpUXQQeItXxXC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, "ccLWvvtHgtajoCYxpUXQQeItXxXC");
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663907);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663908);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_get_monitoring_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663909);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_get_keyCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663910);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663912);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663913);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_PostInitialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663914);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663915);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_Monitor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663916);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_GetKey_Public_Boolean_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663917);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_GetKeyValues_Public_Void_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663918);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663919);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_CPqFjUHhEZgujVohPVDRTVVIyUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663920);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_xpmuwdDURcmUoRIBDfSyCTDoRXaE_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663921);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_GTuhKfsFJsEgAGOPzuZcadoyqPCC_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663922);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_oINjUlJjvuavBkJeCtbzrmEBriE_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663923);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_vpYCjssfUgYDgfaVMQgoeACLGLo_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663924);
				ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_NdklQsaaFIMKcDSbXivfAJsldNNG_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr, 100663925);
			}

			// Token: 0x170010D2 RID: 4306
			// (get) Token: 0x06003837 RID: 14391 RVA: 0x00114408 File Offset: 0x00112608
			// (set) Token: 0x06003838 RID: 14392 RVA: 0x00114444 File Offset: 0x00112644
			public unsafe bool enabled
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244784, XrefRangeEnd = 244791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170010D3 RID: 4307
			// (get) Token: 0x06003839 RID: 14393 RVA: 0x00114484 File Offset: 0x00112684
			public unsafe bool monitoring
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_get_monitoring_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170010D4 RID: 4308
			// (get) Token: 0x0600383A RID: 14394 RVA: 0x001144C0 File Offset: 0x001126C0
			public unsafe int keyCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_get_keyCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600383B RID: 14395 RVA: 0x001144FC File Offset: 0x001126FC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 244803, RefRangeEnd = 244804, XrefRangeStart = 244791, XrefRangeEnd = 244803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Keyboard()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadSafeUnityInput.Keyboard>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600383C RID: 14396 RVA: 0x00114538 File Offset: 0x00112738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244804, XrefRangeEnd = 244805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Initialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600383D RID: 14397 RVA: 0x0011456C File Offset: 0x0011276C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244805, XrefRangeEnd = 244806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void PostInitialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_PostInitialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600383E RID: 14398 RVA: 0x001145A0 File Offset: 0x001127A0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 244811, RefRangeEnd = 244815, XrefRangeStart = 244806, XrefRangeEnd = 244811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Update()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600383F RID: 14399 RVA: 0x001145D4 File Offset: 0x001127D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244815, XrefRangeEnd = 244819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Monitor(bool state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_Monitor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003840 RID: 14400 RVA: 0x00114614 File Offset: 0x00112814
			[CallerCount(0)]
			public unsafe bool GetKey(KeyCode keyCode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref keyCode;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_GetKey_Public_Boolean_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003841 RID: 14401 RVA: 0x00114660 File Offset: 0x00112860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244819, XrefRangeEnd = 244822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetKeyValues(Il2CppStructArray<bool> values)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_GetKeyValues_Public_Void_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003842 RID: 14402 RVA: 0x001146A4 File Offset: 0x001128A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244822, XrefRangeEnd = 244829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003843 RID: 14403 RVA: 0x001146D8 File Offset: 0x001128D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244829, XrefRangeEnd = 244830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CPqFjUHhEZgujVohPVDRTVVIyUp()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_CPqFjUHhEZgujVohPVDRTVVIyUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003844 RID: 14404 RVA: 0x0011470C File Offset: 0x0011290C
			[CallerCount(0)]
			public unsafe void xpmuwdDURcmUoRIBDfSyCTDoRXaE()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_xpmuwdDURcmUoRIBDfSyCTDoRXaE_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003845 RID: 14405 RVA: 0x00114740 File Offset: 0x00112940
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GTuhKfsFJsEgAGOPzuZcadoyqPCC()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_GTuhKfsFJsEgAGOPzuZcadoyqPCC_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003846 RID: 14406 RVA: 0x00114774 File Offset: 0x00112974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void oINjUlJjvuavBkJeCtbzrmEBriE()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_oINjUlJjvuavBkJeCtbzrmEBriE_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003847 RID: 14407 RVA: 0x001147A8 File Offset: 0x001129A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244830, XrefRangeEnd = 244833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void vpYCjssfUgYDgfaVMQgoeACLGLo()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_vpYCjssfUgYDgfaVMQgoeACLGLo_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003848 RID: 14408 RVA: 0x001147DC File Offset: 0x001129DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244833, XrefRangeEnd = 244836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void NdklQsaaFIMKcDSbXivfAJsldNNG()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Keyboard.NativeMethodInfoPtr_NdklQsaaFIMKcDSbXivfAJsldNNG_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003849 RID: 14409 RVA: 0x00013757 File Offset: 0x00011957
			public Keyboard(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010C2 RID: 4290
			// (get) Token: 0x0600384A RID: 14410 RVA: 0x00114810 File Offset: 0x00112A10
			// (set) Token: 0x0600384B RID: 14411 RVA: 0x00013760 File Offset: 0x00011960
			public unsafe static int MXvdFwIPBexhyMATfJEjXZJJhWG
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_MXvdFwIPBexhyMATfJEjXZJJhWG, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_MXvdFwIPBexhyMATfJEjXZJJhWG, (void*)(&value));
				}
			}

			// Token: 0x170010C3 RID: 4291
			// (get) Token: 0x0600384C RID: 14412 RVA: 0x0011482C File Offset: 0x00112A2C
			// (set) Token: 0x0600384D RID: 14413 RVA: 0x0001376E File Offset: 0x0001196E
			public unsafe static int keyValueIndex_Escape
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_Escape, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_Escape, (void*)(&value));
				}
			}

			// Token: 0x170010C4 RID: 4292
			// (get) Token: 0x0600384E RID: 14414 RVA: 0x00114848 File Offset: 0x00112A48
			// (set) Token: 0x0600384F RID: 14415 RVA: 0x0001377C File Offset: 0x0001197C
			public unsafe static int keyValueIndex_Menu
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_Menu, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_Menu, (void*)(&value));
				}
			}

			// Token: 0x170010C5 RID: 4293
			// (get) Token: 0x06003850 RID: 14416 RVA: 0x00114864 File Offset: 0x00112A64
			// (set) Token: 0x06003851 RID: 14417 RVA: 0x0001378A File Offset: 0x0001198A
			public unsafe static int keyValueIndex_F2
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_F2, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_F2, (void*)(&value));
				}
			}

			// Token: 0x170010C6 RID: 4294
			// (get) Token: 0x06003852 RID: 14418 RVA: 0x00114880 File Offset: 0x00112A80
			// (set) Token: 0x06003853 RID: 14419 RVA: 0x00013798 File Offset: 0x00011998
			public unsafe static int keyValueIndex_UpArrow
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_UpArrow, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_UpArrow, (void*)(&value));
				}
			}

			// Token: 0x170010C7 RID: 4295
			// (get) Token: 0x06003854 RID: 14420 RVA: 0x0011489C File Offset: 0x00112A9C
			// (set) Token: 0x06003855 RID: 14421 RVA: 0x000137A6 File Offset: 0x000119A6
			public unsafe static int keyValueIndex_RightArrow
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_RightArrow, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_RightArrow, (void*)(&value));
				}
			}

			// Token: 0x170010C8 RID: 4296
			// (get) Token: 0x06003856 RID: 14422 RVA: 0x001148B8 File Offset: 0x00112AB8
			// (set) Token: 0x06003857 RID: 14423 RVA: 0x000137B4 File Offset: 0x000119B4
			public unsafe static int keyValueIndex_DownArrow
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_DownArrow, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_DownArrow, (void*)(&value));
				}
			}

			// Token: 0x170010C9 RID: 4297
			// (get) Token: 0x06003858 RID: 14424 RVA: 0x001148D4 File Offset: 0x00112AD4
			// (set) Token: 0x06003859 RID: 14425 RVA: 0x000137C2 File Offset: 0x000119C2
			public unsafe static int keyValueIndex_LeftArrow
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_LeftArrow, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_keyValueIndex_LeftArrow, (void*)(&value));
				}
			}

			// Token: 0x170010CA RID: 4298
			// (get) Token: 0x0600385A RID: 14426 RVA: 0x001148F0 File Offset: 0x00112AF0
			// (set) Token: 0x0600385B RID: 14427 RVA: 0x000137D0 File Offset: 0x000119D0
			public unsafe static Il2CppStructArray<int> vWEqvAByfIJzuerfCHjyPjbltGf
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_vWEqvAByfIJzuerfCHjyPjbltGf, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_vWEqvAByfIJzuerfCHjyPjbltGf, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010CB RID: 4299
			// (get) Token: 0x0600385C RID: 14428 RVA: 0x00114918 File Offset: 0x00112B18
			// (set) Token: 0x0600385D RID: 14429 RVA: 0x000137E2 File Offset: 0x000119E2
			public unsafe int wSOrwFBNHJCgwHpdCNaWBdHhEjOI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_wSOrwFBNHJCgwHpdCNaWBdHhEjOI);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_wSOrwFBNHJCgwHpdCNaWBdHhEjOI)) = value;
				}
			}

			// Token: 0x170010CC RID: 4300
			// (get) Token: 0x0600385E RID: 14430 RVA: 0x00114940 File Offset: 0x00112B40
			// (set) Token: 0x0600385F RID: 14431 RVA: 0x000137FD File Offset: 0x000119FD
			public unsafe Il2CppStructArray<int> iGppYSmdCQQOOAuolPgqgTBkCRm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_iGppYSmdCQQOOAuolPgqgTBkCRm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_iGppYSmdCQQOOAuolPgqgTBkCRm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010CD RID: 4301
			// (get) Token: 0x06003860 RID: 14432 RVA: 0x00114970 File Offset: 0x00112B70
			// (set) Token: 0x06003861 RID: 14433 RVA: 0x0001381C File Offset: 0x00011A1C
			public unsafe Il2CppStructArray<bool> yMWHcoZgVBayuPKzlxlxgqwAhpR
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_yMWHcoZgVBayuPKzlxlxgqwAhpR);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_yMWHcoZgVBayuPKzlxlxgqwAhpR), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010CE RID: 4302
			// (get) Token: 0x06003862 RID: 14434 RVA: 0x001149A0 File Offset: 0x00112BA0
			// (set) Token: 0x06003863 RID: 14435 RVA: 0x0001383B File Offset: 0x00011A3B
			public unsafe bool kOIBhhDgDUQCZtioVlUwqEtbkMdb
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb)) = value;
				}
			}

			// Token: 0x170010CF RID: 4303
			// (get) Token: 0x06003864 RID: 14436 RVA: 0x001149C8 File Offset: 0x00112BC8
			// (set) Token: 0x06003865 RID: 14437 RVA: 0x00013856 File Offset: 0x00011A56
			public unsafe int eGfSoiZNGPyXfKQRmWaRNSIUcct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_eGfSoiZNGPyXfKQRmWaRNSIUcct);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_eGfSoiZNGPyXfKQRmWaRNSIUcct)) = value;
				}
			}

			// Token: 0x170010D0 RID: 4304
			// (get) Token: 0x06003866 RID: 14438 RVA: 0x001149F0 File Offset: 0x00112BF0
			// (set) Token: 0x06003867 RID: 14439 RVA: 0x00013871 File Offset: 0x00011A71
			public unsafe bool evYjOreRqjMHReoKHTuuAprqbVL
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_evYjOreRqjMHReoKHTuuAprqbVL);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_evYjOreRqjMHReoKHTuuAprqbVL)) = value;
				}
			}

			// Token: 0x170010D1 RID: 4305
			// (get) Token: 0x06003868 RID: 14440 RVA: 0x00114A18 File Offset: 0x00112C18
			// (set) Token: 0x06003869 RID: 14441 RVA: 0x0001388C File Offset: 0x00011A8C
			public unsafe bool ccLWvvtHgtajoCYxpUXQQeItXxXC
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_ccLWvvtHgtajoCYxpUXQQeItXxXC);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Keyboard.NativeFieldInfoPtr_ccLWvvtHgtajoCYxpUXQQeItXxXC)) = value;
				}
			}

			// Token: 0x04002F61 RID: 12129
			private static readonly IntPtr NativeFieldInfoPtr_MXvdFwIPBexhyMATfJEjXZJJhWG;

			// Token: 0x04002F62 RID: 12130
			private static readonly IntPtr NativeFieldInfoPtr_keyValueIndex_Escape;

			// Token: 0x04002F63 RID: 12131
			private static readonly IntPtr NativeFieldInfoPtr_keyValueIndex_Menu;

			// Token: 0x04002F64 RID: 12132
			private static readonly IntPtr NativeFieldInfoPtr_keyValueIndex_F2;

			// Token: 0x04002F65 RID: 12133
			private static readonly IntPtr NativeFieldInfoPtr_keyValueIndex_UpArrow;

			// Token: 0x04002F66 RID: 12134
			private static readonly IntPtr NativeFieldInfoPtr_keyValueIndex_RightArrow;

			// Token: 0x04002F67 RID: 12135
			private static readonly IntPtr NativeFieldInfoPtr_keyValueIndex_DownArrow;

			// Token: 0x04002F68 RID: 12136
			private static readonly IntPtr NativeFieldInfoPtr_keyValueIndex_LeftArrow;

			// Token: 0x04002F69 RID: 12137
			private static readonly IntPtr NativeFieldInfoPtr_vWEqvAByfIJzuerfCHjyPjbltGf;

			// Token: 0x04002F6A RID: 12138
			private static readonly IntPtr NativeFieldInfoPtr_wSOrwFBNHJCgwHpdCNaWBdHhEjOI;

			// Token: 0x04002F6B RID: 12139
			private static readonly IntPtr NativeFieldInfoPtr_iGppYSmdCQQOOAuolPgqgTBkCRm;

			// Token: 0x04002F6C RID: 12140
			private static readonly IntPtr NativeFieldInfoPtr_yMWHcoZgVBayuPKzlxlxgqwAhpR;

			// Token: 0x04002F6D RID: 12141
			private static readonly IntPtr NativeFieldInfoPtr_kOIBhhDgDUQCZtioVlUwqEtbkMdb;

			// Token: 0x04002F6E RID: 12142
			private static readonly IntPtr NativeFieldInfoPtr_eGfSoiZNGPyXfKQRmWaRNSIUcct;

			// Token: 0x04002F6F RID: 12143
			private static readonly IntPtr NativeFieldInfoPtr_evYjOreRqjMHReoKHTuuAprqbVL;

			// Token: 0x04002F70 RID: 12144
			private static readonly IntPtr NativeFieldInfoPtr_ccLWvvtHgtajoCYxpUXQQeItXxXC;

			// Token: 0x04002F71 RID: 12145
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x04002F72 RID: 12146
			private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

			// Token: 0x04002F73 RID: 12147
			private static readonly IntPtr NativeMethodInfoPtr_get_monitoring_Public_get_Boolean_0;

			// Token: 0x04002F74 RID: 12148
			private static readonly IntPtr NativeMethodInfoPtr_get_keyCount_Public_get_Int32_0;

			// Token: 0x04002F75 RID: 12149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002F76 RID: 12150
			private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

			// Token: 0x04002F77 RID: 12151
			private static readonly IntPtr NativeMethodInfoPtr_PostInitialize_Public_Void_0;

			// Token: 0x04002F78 RID: 12152
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

			// Token: 0x04002F79 RID: 12153
			private static readonly IntPtr NativeMethodInfoPtr_Monitor_Public_Void_Boolean_0;

			// Token: 0x04002F7A RID: 12154
			private static readonly IntPtr NativeMethodInfoPtr_GetKey_Public_Boolean_KeyCode_0;

			// Token: 0x04002F7B RID: 12155
			private static readonly IntPtr NativeMethodInfoPtr_GetKeyValues_Public_Void_Il2CppStructArray_1_Boolean_0;

			// Token: 0x04002F7C RID: 12156
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

			// Token: 0x04002F7D RID: 12157
			private static readonly IntPtr NativeMethodInfoPtr_CPqFjUHhEZgujVohPVDRTVVIyUp_Private_Void_0;

			// Token: 0x04002F7E RID: 12158
			private static readonly IntPtr NativeMethodInfoPtr_xpmuwdDURcmUoRIBDfSyCTDoRXaE_Private_Void_0;

			// Token: 0x04002F7F RID: 12159
			private static readonly IntPtr NativeMethodInfoPtr_GTuhKfsFJsEgAGOPzuZcadoyqPCC_Private_Void_0;

			// Token: 0x04002F80 RID: 12160
			private static readonly IntPtr NativeMethodInfoPtr_oINjUlJjvuavBkJeCtbzrmEBriE_Private_Void_0;

			// Token: 0x04002F81 RID: 12161
			private static readonly IntPtr NativeMethodInfoPtr_vpYCjssfUgYDgfaVMQgoeACLGLo_Private_Void_0;

			// Token: 0x04002F82 RID: 12162
			private static readonly IntPtr NativeMethodInfoPtr_NdklQsaaFIMKcDSbXivfAJsldNNG_Private_Void_0;
		}

		// Token: 0x02000237 RID: 567
		public sealed class Mouse : global::Il2CppSystem.Object
		{
			// Token: 0x0600386A RID: 14442 RVA: 0x00114A40 File Offset: 0x00112C40
			// Note: this type is marked as 'beforefieldinit'.
			static Mouse()
			{
				Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadSafeUnityInput>.NativeClassPtr, "Mouse");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr);
				ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, "XQHSiIMpmpLQwAfijbkQiqJbUVm");
				ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, "LwOXjVDDWGcrYCqkRfMxrtTySlw");
				ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, "GuxtgegCZiWJDenlSEVuDZKGNKPu");
				ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_lEPAIAfeGTrdhuJakqffRNfOtKW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, "lEPAIAfeGTrdhuJakqffRNfOtKW");
				ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_eGfSoiZNGPyXfKQRmWaRNSIUcct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, "eGfSoiZNGPyXfKQRmWaRNSIUcct");
				ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_qChreTbMKEmhLHqJfDCPcERpOkX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, "qChreTbMKEmhLHqJfDCPcERpOkX");
				ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_hsTURLMwksugfMVcIbgkshzASVX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, "hsTURLMwksugfMVcIbgkshzASVX");
				ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_nPheAUMVtvFLMSJnkxJMAdUcEsgf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, "nPheAUMVtvFLMSJnkxJMAdUcEsgf");
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_get_monitoring_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663926);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_get_mousePosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663927);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_get_mousePresent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663928);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663929);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_PostInitialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663930);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663931);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_Monitor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663932);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_GetButton_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663933);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_GetAxisRaw_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663934);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_GetButtonValues_Public_Void_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663935);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_GetAxisRawValues_Public_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663936);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_CPqFjUHhEZgujVohPVDRTVVIyUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663937);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_xpmuwdDURcmUoRIBDfSyCTDoRXaE_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663938);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_GTuhKfsFJsEgAGOPzuZcadoyqPCC_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663939);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_oINjUlJjvuavBkJeCtbzrmEBriE_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663940);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_lhagpKyFmxdVIIxzOKNRJolRfNR_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663941);
				ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_NdklQsaaFIMKcDSbXivfAJsldNNG_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr, 100663942);
			}

			// Token: 0x170010DD RID: 4317
			// (get) Token: 0x0600386B RID: 14443 RVA: 0x00114C60 File Offset: 0x00112E60
			public unsafe bool monitoring
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_get_monitoring_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170010DE RID: 4318
			// (get) Token: 0x0600386C RID: 14444 RVA: 0x00114C9C File Offset: 0x00112E9C
			public unsafe Vector3 mousePosition
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_get_mousePosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170010DF RID: 4319
			// (get) Token: 0x0600386D RID: 14445 RVA: 0x00114CD8 File Offset: 0x00112ED8
			public unsafe bool mousePresent
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_get_mousePresent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600386E RID: 14446 RVA: 0x00114D14 File Offset: 0x00112F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244836, XrefRangeEnd = 244844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Mouse()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadSafeUnityInput.Mouse>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600386F RID: 14447 RVA: 0x00114D50 File Offset: 0x00112F50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244844, XrefRangeEnd = 244845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void PostInitialize()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_PostInitialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003870 RID: 14448 RVA: 0x00114D84 File Offset: 0x00112F84
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 244869, RefRangeEnd = 244873, XrefRangeStart = 244845, XrefRangeEnd = 244869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Update()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003871 RID: 14449 RVA: 0x00114DB8 File Offset: 0x00112FB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244873, XrefRangeEnd = 244878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Monitor(bool state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_Monitor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003872 RID: 14450 RVA: 0x00114DF8 File Offset: 0x00112FF8
			[CallerCount(0)]
			public unsafe bool GetButton(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_GetButton_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003873 RID: 14451 RVA: 0x00114E44 File Offset: 0x00113044
			[CallerCount(0)]
			public unsafe float GetAxisRaw(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_GetAxisRaw_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003874 RID: 14452 RVA: 0x00114E90 File Offset: 0x00113090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244878, XrefRangeEnd = 244881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetButtonValues(Il2CppStructArray<bool> buttons)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buttons);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_GetButtonValues_Public_Void_Il2CppStructArray_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003875 RID: 14453 RVA: 0x00114ED4 File Offset: 0x001130D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244881, XrefRangeEnd = 244884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetAxisRawValues(Il2CppStructArray<float> axes)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(axes);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_GetAxisRawValues_Public_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003876 RID: 14454 RVA: 0x00114F18 File Offset: 0x00113118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244884, XrefRangeEnd = 244886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CPqFjUHhEZgujVohPVDRTVVIyUp()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_CPqFjUHhEZgujVohPVDRTVVIyUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003877 RID: 14455 RVA: 0x00114F4C File Offset: 0x0011314C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244886, XrefRangeEnd = 244888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void xpmuwdDURcmUoRIBDfSyCTDoRXaE()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_xpmuwdDURcmUoRIBDfSyCTDoRXaE_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003878 RID: 14456 RVA: 0x00114F80 File Offset: 0x00113180
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GTuhKfsFJsEgAGOPzuZcadoyqPCC()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_GTuhKfsFJsEgAGOPzuZcadoyqPCC_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003879 RID: 14457 RVA: 0x00114FB4 File Offset: 0x001131B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void oINjUlJjvuavBkJeCtbzrmEBriE()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_oINjUlJjvuavBkJeCtbzrmEBriE_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600387A RID: 14458 RVA: 0x00114FE8 File Offset: 0x001131E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244888, XrefRangeEnd = 244891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void lhagpKyFmxdVIIxzOKNRJolRfNR()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_lhagpKyFmxdVIIxzOKNRJolRfNR_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600387B RID: 14459 RVA: 0x0011501C File Offset: 0x0011321C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244891, XrefRangeEnd = 244894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void NdklQsaaFIMKcDSbXivfAJsldNNG()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadSafeUnityInput.Mouse.NativeMethodInfoPtr_NdklQsaaFIMKcDSbXivfAJsldNNG_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600387C RID: 14460 RVA: 0x000138A7 File Offset: 0x00011AA7
			public Mouse(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010D5 RID: 4309
			// (get) Token: 0x0600387D RID: 14461 RVA: 0x00115050 File Offset: 0x00113250
			// (set) Token: 0x0600387E RID: 14462 RVA: 0x000138B0 File Offset: 0x00011AB0
			public unsafe static int XQHSiIMpmpLQwAfijbkQiqJbUVm
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm, (void*)(&value));
				}
			}

			// Token: 0x170010D6 RID: 4310
			// (get) Token: 0x0600387F RID: 14463 RVA: 0x0011506C File Offset: 0x0011326C
			// (set) Token: 0x06003880 RID: 14464 RVA: 0x000138BE File Offset: 0x00011ABE
			public unsafe static int LwOXjVDDWGcrYCqkRfMxrtTySlw
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw, (void*)(&value));
				}
			}

			// Token: 0x170010D7 RID: 4311
			// (get) Token: 0x06003881 RID: 14465 RVA: 0x00115088 File Offset: 0x00113288
			// (set) Token: 0x06003882 RID: 14466 RVA: 0x000138CC File Offset: 0x00011ACC
			public unsafe Il2CppStructArray<bool> GuxtgegCZiWJDenlSEVuDZKGNKPu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D8 RID: 4312
			// (get) Token: 0x06003883 RID: 14467 RVA: 0x001150B8 File Offset: 0x001132B8
			// (set) Token: 0x06003884 RID: 14468 RVA: 0x000138EB File Offset: 0x00011AEB
			public unsafe Il2CppStructArray<float> lEPAIAfeGTrdhuJakqffRNfOtKW
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_lEPAIAfeGTrdhuJakqffRNfOtKW);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_lEPAIAfeGTrdhuJakqffRNfOtKW), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D9 RID: 4313
			// (get) Token: 0x06003885 RID: 14469 RVA: 0x001150E8 File Offset: 0x001132E8
			// (set) Token: 0x06003886 RID: 14470 RVA: 0x0001390A File Offset: 0x00011B0A
			public unsafe int eGfSoiZNGPyXfKQRmWaRNSIUcct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_eGfSoiZNGPyXfKQRmWaRNSIUcct);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_eGfSoiZNGPyXfKQRmWaRNSIUcct)) = value;
				}
			}

			// Token: 0x170010DA RID: 4314
			// (get) Token: 0x06003887 RID: 14471 RVA: 0x00115110 File Offset: 0x00113310
			// (set) Token: 0x06003888 RID: 14472 RVA: 0x00013925 File Offset: 0x00011B25
			public unsafe Vector3 qChreTbMKEmhLHqJfDCPcERpOkX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_qChreTbMKEmhLHqJfDCPcERpOkX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_qChreTbMKEmhLHqJfDCPcERpOkX)) = value;
				}
			}

			// Token: 0x170010DB RID: 4315
			// (get) Token: 0x06003889 RID: 14473 RVA: 0x00115138 File Offset: 0x00113338
			// (set) Token: 0x0600388A RID: 14474 RVA: 0x00013940 File Offset: 0x00011B40
			public unsafe bool hsTURLMwksugfMVcIbgkshzASVX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_hsTURLMwksugfMVcIbgkshzASVX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_hsTURLMwksugfMVcIbgkshzASVX)) = value;
				}
			}

			// Token: 0x170010DC RID: 4316
			// (get) Token: 0x0600388B RID: 14475 RVA: 0x00115160 File Offset: 0x00113360
			// (set) Token: 0x0600388C RID: 14476 RVA: 0x0001395B File Offset: 0x00011B5B
			public unsafe bool nPheAUMVtvFLMSJnkxJMAdUcEsgf
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_nPheAUMVtvFLMSJnkxJMAdUcEsgf);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadSafeUnityInput.Mouse.NativeFieldInfoPtr_nPheAUMVtvFLMSJnkxJMAdUcEsgf)) = value;
				}
			}

			// Token: 0x04002F83 RID: 12163
			private static readonly IntPtr NativeFieldInfoPtr_XQHSiIMpmpLQwAfijbkQiqJbUVm;

			// Token: 0x04002F84 RID: 12164
			private static readonly IntPtr NativeFieldInfoPtr_LwOXjVDDWGcrYCqkRfMxrtTySlw;

			// Token: 0x04002F85 RID: 12165
			private static readonly IntPtr NativeFieldInfoPtr_GuxtgegCZiWJDenlSEVuDZKGNKPu;

			// Token: 0x04002F86 RID: 12166
			private static readonly IntPtr NativeFieldInfoPtr_lEPAIAfeGTrdhuJakqffRNfOtKW;

			// Token: 0x04002F87 RID: 12167
			private static readonly IntPtr NativeFieldInfoPtr_eGfSoiZNGPyXfKQRmWaRNSIUcct;

			// Token: 0x04002F88 RID: 12168
			private static readonly IntPtr NativeFieldInfoPtr_qChreTbMKEmhLHqJfDCPcERpOkX;

			// Token: 0x04002F89 RID: 12169
			private static readonly IntPtr NativeFieldInfoPtr_hsTURLMwksugfMVcIbgkshzASVX;

			// Token: 0x04002F8A RID: 12170
			private static readonly IntPtr NativeFieldInfoPtr_nPheAUMVtvFLMSJnkxJMAdUcEsgf;

			// Token: 0x04002F8B RID: 12171
			private static readonly IntPtr NativeMethodInfoPtr_get_monitoring_Public_get_Boolean_0;

			// Token: 0x04002F8C RID: 12172
			private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_get_Vector3_0;

			// Token: 0x04002F8D RID: 12173
			private static readonly IntPtr NativeMethodInfoPtr_get_mousePresent_Public_get_Boolean_0;

			// Token: 0x04002F8E RID: 12174
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002F8F RID: 12175
			private static readonly IntPtr NativeMethodInfoPtr_PostInitialize_Public_Void_0;

			// Token: 0x04002F90 RID: 12176
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

			// Token: 0x04002F91 RID: 12177
			private static readonly IntPtr NativeMethodInfoPtr_Monitor_Public_Void_Boolean_0;

			// Token: 0x04002F92 RID: 12178
			private static readonly IntPtr NativeMethodInfoPtr_GetButton_Public_Boolean_Int32_0;

			// Token: 0x04002F93 RID: 12179
			private static readonly IntPtr NativeMethodInfoPtr_GetAxisRaw_Public_Single_Int32_0;

			// Token: 0x04002F94 RID: 12180
			private static readonly IntPtr NativeMethodInfoPtr_GetButtonValues_Public_Void_Il2CppStructArray_1_Boolean_0;

			// Token: 0x04002F95 RID: 12181
			private static readonly IntPtr NativeMethodInfoPtr_GetAxisRawValues_Public_Void_Il2CppStructArray_1_Single_0;

			// Token: 0x04002F96 RID: 12182
			private static readonly IntPtr NativeMethodInfoPtr_CPqFjUHhEZgujVohPVDRTVVIyUp_Private_Void_0;

			// Token: 0x04002F97 RID: 12183
			private static readonly IntPtr NativeMethodInfoPtr_xpmuwdDURcmUoRIBDfSyCTDoRXaE_Private_Void_0;

			// Token: 0x04002F98 RID: 12184
			private static readonly IntPtr NativeMethodInfoPtr_GTuhKfsFJsEgAGOPzuZcadoyqPCC_Private_Void_0;

			// Token: 0x04002F99 RID: 12185
			private static readonly IntPtr NativeMethodInfoPtr_oINjUlJjvuavBkJeCtbzrmEBriE_Private_Void_0;

			// Token: 0x04002F9A RID: 12186
			private static readonly IntPtr NativeMethodInfoPtr_lhagpKyFmxdVIIxzOKNRJolRfNR_Private_Void_0;

			// Token: 0x04002F9B RID: 12187
			private static readonly IntPtr NativeMethodInfoPtr_NdklQsaaFIMKcDSbXivfAJsldNNG_Private_Void_0;
		}
	}
}
