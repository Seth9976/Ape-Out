using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Classes.Utility
{
	// Token: 0x020001FA RID: 506
	[Serializable]
	public class TimerAbs : Object
	{
		// Token: 0x060034AE RID: 13486 RVA: 0x001074E8 File Offset: 0x001056E8
		// Note: this type is marked as 'beforefieldinit'.
		static TimerAbs()
		{
			Il2CppClassPointerStore<TimerAbs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Classes.Utility", "TimerAbs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerAbs>.NativeClassPtr);
			TimerAbs.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerAbs>.NativeClassPtr, "running");
			TimerAbs.NativeFieldInfoPtr_zCJFOqdTuGVMjEYLkCAUFuuudKYK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerAbs>.NativeClassPtr, "zCJFOqdTuGVMjEYLkCAUFuuudKYK");
			TimerAbs.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerAbs>.NativeClassPtr, "length");
			TimerAbs.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerAbs>.NativeClassPtr, 100676527);
			TimerAbs.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerAbs>.NativeClassPtr, 100676528);
			TimerAbs.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerAbs>.NativeClassPtr, 100676529);
			TimerAbs.NativeMethodInfoPtr_Start_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerAbs>.NativeClassPtr, 100676530);
			TimerAbs.NativeMethodInfoPtr_Update_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerAbs>.NativeClassPtr, 100676531);
			TimerAbs.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerAbs>.NativeClassPtr, 100676532);
			TimerAbs.NativeMethodInfoPtr_SetLength_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerAbs>.NativeClassPtr, 100676533);
			TimerAbs.NativeMethodInfoPtr_Clone_Public_TimerAbs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerAbs>.NativeClassPtr, 100676534);
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x001075F4 File Offset: 0x001057F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerAbs()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerAbs>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerAbs.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x00107630 File Offset: 0x00105830
		[CallerCount(0)]
		public unsafe TimerAbs(double inLength)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerAbs>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerAbs.NativeMethodInfoPtr__ctor_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x00107678 File Offset: 0x00105878
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 345858, RefRangeEnd = 345863, XrefRangeStart = 345854, XrefRangeEnd = 345858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerAbs.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x001076AC File Offset: 0x001058AC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 345867, RefRangeEnd = 345877, XrefRangeStart = 345863, XrefRangeEnd = 345867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start(double inLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerAbs.NativeMethodInfoPtr_Start_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x001076EC File Offset: 0x001058EC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 345881, RefRangeEnd = 345889, XrefRangeStart = 345877, XrefRangeEnd = 345881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerAbs.NativeMethodInfoPtr_Update_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x00107728 File Offset: 0x00105928
		[CallerCount(0)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerAbs.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x0010775C File Offset: 0x0010595C
		[CallerCount(0)]
		public unsafe void SetLength(double inLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerAbs.NativeMethodInfoPtr_SetLength_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x0010779C File Offset: 0x0010599C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 345889, XrefRangeEnd = 345892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerAbs Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerAbs.NativeMethodInfoPtr_Clone_Public_TimerAbs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TimerAbs>(intPtr3) : null;
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x00012024 File Offset: 0x00010224
		public TimerAbs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x001077DC File Offset: 0x001059DC
		// (set) Token: 0x060034B9 RID: 13497 RVA: 0x0001202D File Offset: 0x0001022D
		public unsafe bool running
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerAbs.NativeFieldInfoPtr_running);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerAbs.NativeFieldInfoPtr_running)) = value;
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x060034BA RID: 13498 RVA: 0x00107804 File Offset: 0x00105A04
		// (set) Token: 0x060034BB RID: 13499 RVA: 0x00012048 File Offset: 0x00010248
		public unsafe double zCJFOqdTuGVMjEYLkCAUFuuudKYK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerAbs.NativeFieldInfoPtr_zCJFOqdTuGVMjEYLkCAUFuuudKYK);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerAbs.NativeFieldInfoPtr_zCJFOqdTuGVMjEYLkCAUFuuudKYK)) = value;
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x060034BC RID: 13500 RVA: 0x0010782C File Offset: 0x00105A2C
		// (set) Token: 0x060034BD RID: 13501 RVA: 0x00012063 File Offset: 0x00010263
		public unsafe double length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerAbs.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerAbs.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x04002CF9 RID: 11513
		private static readonly IntPtr NativeFieldInfoPtr_running;

		// Token: 0x04002CFA RID: 11514
		private static readonly IntPtr NativeFieldInfoPtr_zCJFOqdTuGVMjEYLkCAUFuuudKYK;

		// Token: 0x04002CFB RID: 11515
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04002CFC RID: 11516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002CFD RID: 11517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;

		// Token: 0x04002CFE RID: 11518
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04002CFF RID: 11519
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_Double_0;

		// Token: 0x04002D00 RID: 11520
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Boolean_0;

		// Token: 0x04002D01 RID: 11521
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002D02 RID: 11522
		private static readonly IntPtr NativeMethodInfoPtr_SetLength_Public_Void_Double_0;

		// Token: 0x04002D03 RID: 11523
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_TimerAbs_0;
	}
}
