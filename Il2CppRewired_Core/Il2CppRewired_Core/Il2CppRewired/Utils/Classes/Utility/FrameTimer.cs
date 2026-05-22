using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x020001FD RID: 509
	[Serializable]
	public class FrameTimer : Object
	{
		// Token: 0x060034DF RID: 13535 RVA: 0x00107F84 File Offset: 0x00106184
		// Note: this type is marked as 'beforefieldinit'.
		static FrameTimer()
		{
			Il2CppClassPointerStore<FrameTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "FrameTimer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr);
			FrameTimer.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr, "running");
			FrameTimer.NativeFieldInfoPtr_timeRemaining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr, "timeRemaining");
			FrameTimer.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr, "length");
			FrameTimer.NativeFieldInfoPtr_overrunBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr, "overrunBuffer");
			FrameTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr, 100676552);
			FrameTimer.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr, 100676553);
			FrameTimer.NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr, 100676554);
			FrameTimer.NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr, 100676555);
			FrameTimer.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Boolean_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr, 100676556);
			FrameTimer.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr, 100676557);
			FrameTimer.NativeMethodInfoPtr_pgfhqKfhGgKBBPukfetrEaLsVJh_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr, 100676558);
			FrameTimer.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Public_FrameTimer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr, 100676559);
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x001080A4 File Offset: 0x001062A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FrameTimer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x001080E0 File Offset: 0x001062E0
		[CallerCount(0)]
		public unsafe FrameTimer(double inLength)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameTimer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimer.NativeMethodInfoPtr__ctor_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x00108128 File Offset: 0x00106328
		[CallerCount(0)]
		public unsafe void qeDEyDaZsAupdNZCUOgsfUHyXvg()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimer.NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x0010815C File Offset: 0x0010635C
		[CallerCount(0)]
		public unsafe void qeDEyDaZsAupdNZCUOgsfUHyXvg(double A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimer.NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x0010819C File Offset: 0x0010639C
		[CallerCount(0)]
		public unsafe bool xozDTcGUrsCTUDmjINWIvPSceAOJ(double A_1, double A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref A_2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimer.NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Boolean_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x001081F4 File Offset: 0x001063F4
		[CallerCount(0)]
		public unsafe void GMFpQqtyJcjzYToWCrZsZQAhPYh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimer.NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x00108228 File Offset: 0x00106428
		[CallerCount(0)]
		public unsafe void pgfhqKfhGgKBBPukfetrEaLsVJh(double A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimer.NativeMethodInfoPtr_pgfhqKfhGgKBBPukfetrEaLsVJh_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x00108268 File Offset: 0x00106468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345925, XrefRangeEnd = 345928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FrameTimer dLAxRoWNebGZzafOZSROBGeqqVrC()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FrameTimer.NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Public_FrameTimer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FrameTimer>(intPtr3) : null;
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x00012132 File Offset: 0x00010332
		public FrameTimer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x060034E9 RID: 13545 RVA: 0x001082A8 File Offset: 0x001064A8
		// (set) Token: 0x060034EA RID: 13546 RVA: 0x0001213B File Offset: 0x0001033B
		public unsafe bool running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimer.NativeFieldInfoPtr_running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimer.NativeFieldInfoPtr_running)) = value;
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x060034EB RID: 13547 RVA: 0x001082D0 File Offset: 0x001064D0
		// (set) Token: 0x060034EC RID: 13548 RVA: 0x00012156 File Offset: 0x00010356
		public unsafe double timeRemaining
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimer.NativeFieldInfoPtr_timeRemaining);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimer.NativeFieldInfoPtr_timeRemaining)) = value;
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x060034ED RID: 13549 RVA: 0x001082F8 File Offset: 0x001064F8
		// (set) Token: 0x060034EE RID: 13550 RVA: 0x00012171 File Offset: 0x00010371
		public unsafe double length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimer.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimer.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x060034EF RID: 13551 RVA: 0x00108320 File Offset: 0x00106520
		// (set) Token: 0x060034F0 RID: 13552 RVA: 0x0001218C File Offset: 0x0001038C
		public unsafe double overrunBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimer.NativeFieldInfoPtr_overrunBuffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FrameTimer.NativeFieldInfoPtr_overrunBuffer)) = value;
			}
		}

		// Token: 0x04002D1B RID: 11547
		private static readonly IntPtr NativeFieldInfoPtr_running;

		// Token: 0x04002D1C RID: 11548
		private static readonly IntPtr NativeFieldInfoPtr_timeRemaining;

		// Token: 0x04002D1D RID: 11549
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04002D1E RID: 11550
		private static readonly IntPtr NativeFieldInfoPtr_overrunBuffer;

		// Token: 0x04002D1F RID: 11551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D20 RID: 11552
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04002D21 RID: 11553
		private static readonly IntPtr NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_0;

		// Token: 0x04002D22 RID: 11554
		private static readonly IntPtr NativeMethodInfoPtr_qeDEyDaZsAupdNZCUOgsfUHyXvg_Public_Void_Double_0;

		// Token: 0x04002D23 RID: 11555
		private static readonly IntPtr NativeMethodInfoPtr_xozDTcGUrsCTUDmjINWIvPSceAOJ_Public_Boolean_Double_Double_0;

		// Token: 0x04002D24 RID: 11556
		private static readonly IntPtr NativeMethodInfoPtr_GMFpQqtyJcjzYToWCrZsZQAhPYh_Public_Void_0;

		// Token: 0x04002D25 RID: 11557
		private static readonly IntPtr NativeMethodInfoPtr_pgfhqKfhGgKBBPukfetrEaLsVJh_Public_Void_Double_0;

		// Token: 0x04002D26 RID: 11558
		private static readonly IntPtr NativeMethodInfoPtr_dLAxRoWNebGZzafOZSROBGeqqVrC_Public_FrameTimer_0;
	}
}
