using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x020001FC RID: 508
	[Serializable]
	public class Timer : Object
	{
		// Token: 0x060034CE RID: 13518 RVA: 0x00107BC0 File Offset: 0x00105DC0
		// Note: this type is marked as 'beforefieldinit'.
		static Timer()
		{
			Il2CppClassPointerStore<Timer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "Timer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timer>.NativeClassPtr);
			Timer.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "running");
			Timer.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "timer");
			Timer.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "length");
			Timer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100676543);
			Timer.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100676544);
			Timer.NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100676545);
			Timer.NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100676546);
			Timer.NativeMethodInfoPtr_JpEnYFPDWbYyzehsuSxrZZAOqRl_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100676547);
			Timer.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100676548);
			Timer.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100676549);
			Timer.NativeMethodInfoPtr_pgfhqKfhGgKBBPukfetrEaLsVJh_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100676550);
			Timer.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Public_Timer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100676551);
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x00107CE0 File Offset: 0x00105EE0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Timer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x00107D1C File Offset: 0x00105F1C
		[CallerCount(0)]
		public unsafe Timer(double inLength)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr__ctor_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x00107D64 File Offset: 0x00105F64
		[CallerCount(0)]
		public unsafe void qeDEyDaZsAupdNZCUOgsfUHyXvg()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x00107D98 File Offset: 0x00105F98
		[CallerCount(0)]
		public unsafe void qeDEyDaZsAupdNZCUOgsfUHyXvg(double A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x00107DD8 File Offset: 0x00105FD8
		[CallerCount(0)]
		public unsafe void JpEnYFPDWbYyzehsuSxrZZAOqRl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_JpEnYFPDWbYyzehsuSxrZZAOqRl_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x00107E0C File Offset: 0x0010600C
		[CallerCount(0)]
		public unsafe bool xozDTcGUrsCTUDmjINWIvPSceAOJ(double A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Boolean_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x00107E58 File Offset: 0x00106058
		[CallerCount(0)]
		public unsafe void GMFpQqtyJcjzYToWCrZsZQAhPYh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x00107E8C File Offset: 0x0010608C
		[CallerCount(0)]
		public unsafe void pgfhqKfhGgKBBPukfetrEaLsVJh(double A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_pgfhqKfhGgKBBPukfetrEaLsVJh_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x00107ECC File Offset: 0x001060CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345922, XrefRangeEnd = 345925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Timer dLAxRoWNebGZzafOZSROBGeqqVrC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Public_Timer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Timer>(intPtr3) : null;
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x000120D8 File Offset: 0x000102D8
		public Timer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x060034D9 RID: 13529 RVA: 0x00107F0C File Offset: 0x0010610C
		// (set) Token: 0x060034DA RID: 13530 RVA: 0x000120E1 File Offset: 0x000102E1
		public unsafe bool running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_running)) = value;
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x060034DB RID: 13531 RVA: 0x00107F34 File Offset: 0x00106134
		// (set) Token: 0x060034DC RID: 13532 RVA: 0x000120FC File Offset: 0x000102FC
		public unsafe double timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x060034DD RID: 13533 RVA: 0x00107F5C File Offset: 0x0010615C
		// (set) Token: 0x060034DE RID: 13534 RVA: 0x00012117 File Offset: 0x00010317
		public unsafe double length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x04002D0F RID: 11535
		private static readonly IntPtr NativeFieldInfoPtr_running;

		// Token: 0x04002D10 RID: 11536
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04002D11 RID: 11537
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04002D12 RID: 11538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D13 RID: 11539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04002D14 RID: 11540
		private static readonly IntPtr NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_0;

		// Token: 0x04002D15 RID: 11541
		private static readonly IntPtr NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_Double_0;

		// Token: 0x04002D16 RID: 11542
		private static readonly IntPtr NativeMethodInfoPtr_JpEnYFPDWbYyzehsuSxrZZAOqRl_Public_Void_0;

		// Token: 0x04002D17 RID: 11543
		private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Boolean_Double_0;

		// Token: 0x04002D18 RID: 11544
		private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0;

		// Token: 0x04002D19 RID: 11545
		private static readonly IntPtr NativeMethodInfoPtr_pgfhqKfhGgKBBPukfetrEaLsVJh_Public_Void_Double_0;

		// Token: 0x04002D1A RID: 11546
		private static readonly IntPtr NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Public_Timer_0;
	}
}
