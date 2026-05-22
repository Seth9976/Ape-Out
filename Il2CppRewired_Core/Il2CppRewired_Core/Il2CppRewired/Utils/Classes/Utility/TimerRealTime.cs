using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x020001FB RID: 507
	[Serializable]
	public class TimerRealTime : Object
	{
		// Token: 0x060034BE RID: 13502 RVA: 0x00107854 File Offset: 0x00105A54
		// Note: this type is marked as 'beforefieldinit'.
		static TimerRealTime()
		{
			Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "TimerRealTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr);
			TimerRealTime.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr, "running");
			TimerRealTime.NativeFieldInfoPtr_zCJFOqdTuGVMjEYLkCAUFuuudKYK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr, "zCJFOqdTuGVMjEYLkCAUFuuudKYK");
			TimerRealTime.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr, "length");
			TimerRealTime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr, 100676535);
			TimerRealTime.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr, 100676536);
			TimerRealTime.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr, 100676537);
			TimerRealTime.NativeMethodInfoPtr_Start_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr, 100676538);
			TimerRealTime.NativeMethodInfoPtr_Update_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr, 100676539);
			TimerRealTime.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr, 100676540);
			TimerRealTime.NativeMethodInfoPtr_SetLength_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr, 100676541);
			TimerRealTime.NativeMethodInfoPtr_Clone_Public_TimerAbs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr, 100676542);
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x00107960 File Offset: 0x00105B60
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerRealTime()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerRealTime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x0010799C File Offset: 0x00105B9C
		[CallerCount(0)]
		public unsafe TimerRealTime(double inLength)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerRealTime>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerRealTime.NativeMethodInfoPtr__ctor_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x001079E4 File Offset: 0x00105BE4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 345896, RefRangeEnd = 345906, XrefRangeStart = 345892, XrefRangeEnd = 345896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerRealTime.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x00107A18 File Offset: 0x00105C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345906, XrefRangeEnd = 345910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start(double inLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerRealTime.NativeMethodInfoPtr_Start_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x00107A58 File Offset: 0x00105C58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 345914, RefRangeEnd = 345919, XrefRangeStart = 345910, XrefRangeEnd = 345914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerRealTime.NativeMethodInfoPtr_Update_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x00107A94 File Offset: 0x00105C94
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerRealTime.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x00107AC8 File Offset: 0x00105CC8
		[CallerCount(0)]
		public unsafe void SetLength(double inLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerRealTime.NativeMethodInfoPtr_SetLength_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x00107B08 File Offset: 0x00105D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345919, XrefRangeEnd = 345922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerAbs Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerRealTime.NativeMethodInfoPtr_Clone_Public_TimerAbs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerAbs>(intPtr3) : null;
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x0001207E File Offset: 0x0001027E
		public TimerRealTime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x060034C8 RID: 13512 RVA: 0x00107B48 File Offset: 0x00105D48
		// (set) Token: 0x060034C9 RID: 13513 RVA: 0x00012087 File Offset: 0x00010287
		public unsafe bool running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerRealTime.NativeFieldInfoPtr_running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerRealTime.NativeFieldInfoPtr_running)) = value;
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x060034CA RID: 13514 RVA: 0x00107B70 File Offset: 0x00105D70
		// (set) Token: 0x060034CB RID: 13515 RVA: 0x000120A2 File Offset: 0x000102A2
		public unsafe double zCJFOqdTuGVMjEYLkCAUFuuudKYK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerRealTime.NativeFieldInfoPtr_zCJFOqdTuGVMjEYLkCAUFuuudKYK);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerRealTime.NativeFieldInfoPtr_zCJFOqdTuGVMjEYLkCAUFuuudKYK)) = value;
			}
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x060034CC RID: 13516 RVA: 0x00107B98 File Offset: 0x00105D98
		// (set) Token: 0x060034CD RID: 13517 RVA: 0x000120BD File Offset: 0x000102BD
		public unsafe double length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerRealTime.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerRealTime.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x04002D04 RID: 11524
		private static readonly IntPtr NativeFieldInfoPtr_running;

		// Token: 0x04002D05 RID: 11525
		private static readonly IntPtr NativeFieldInfoPtr_zCJFOqdTuGVMjEYLkCAUFuuudKYK;

		// Token: 0x04002D06 RID: 11526
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04002D07 RID: 11527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D08 RID: 11528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04002D09 RID: 11529
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04002D0A RID: 11530
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_Double_0;

		// Token: 0x04002D0B RID: 11531
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Boolean_0;

		// Token: 0x04002D0C RID: 11532
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002D0D RID: 11533
		private static readonly IntPtr NativeMethodInfoPtr_SetLength_Public_Void_Double_0;

		// Token: 0x04002D0E RID: 11534
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_TimerAbs_0;
	}
}
