using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x0200045C RID: 1116
	public sealed class MarshalAsAttribute : Attribute
	{
		// Token: 0x06004493 RID: 17555 RVA: 0x0013C644 File Offset: 0x0013A844
		// Note: this type is marked as 'beforefieldinit'.
		static MarshalAsAttribute()
		{
			Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "MarshalAsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr);
			MarshalAsAttribute.NativeFieldInfoPtr_MarshalCookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "MarshalCookie");
			MarshalAsAttribute.NativeFieldInfoPtr_MarshalType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "MarshalType");
			MarshalAsAttribute.NativeFieldInfoPtr_MarshalTypeRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "MarshalTypeRef");
			MarshalAsAttribute.NativeFieldInfoPtr_SafeArrayUserDefinedSubType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SafeArrayUserDefinedSubType");
			MarshalAsAttribute.NativeFieldInfoPtr_utype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "utype");
			MarshalAsAttribute.NativeFieldInfoPtr_ArraySubType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "ArraySubType");
			MarshalAsAttribute.NativeFieldInfoPtr_SafeArraySubType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SafeArraySubType");
			MarshalAsAttribute.NativeFieldInfoPtr_SizeConst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SizeConst");
			MarshalAsAttribute.NativeFieldInfoPtr_IidParameterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "IidParameterIndex");
			MarshalAsAttribute.NativeFieldInfoPtr_SizeParamIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, "SizeParamIndex");
			MarshalAsAttribute.NativeMethodInfoPtr_Copy_Internal_MarshalAsAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalAsAttribute>.NativeClassPtr, 100673298);
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x0013C750 File Offset: 0x0013A950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228062, XrefRangeEnd = 228065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalAsAttribute Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarshalAsAttribute.NativeMethodInfoPtr_Copy_Internal_MarshalAsAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalAsAttribute>(intPtr3) : null;
		}

		// Token: 0x06004495 RID: 17557 RVA: 0x0001A0AB File Offset: 0x000182AB
		public MarshalAsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06004496 RID: 17558 RVA: 0x0013C790 File Offset: 0x0013A990
		// (set) Token: 0x06004497 RID: 17559 RVA: 0x0001A0B4 File Offset: 0x000182B4
		public unsafe string MarshalCookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalCookie);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalCookie), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x06004498 RID: 17560 RVA: 0x0013C7B8 File Offset: 0x0013A9B8
		// (set) Token: 0x06004499 RID: 17561 RVA: 0x0001A0D3 File Offset: 0x000182D3
		public unsafe string MarshalType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x0600449A RID: 17562 RVA: 0x0013C7E0 File Offset: 0x0013A9E0
		// (set) Token: 0x0600449B RID: 17563 RVA: 0x0001A0F2 File Offset: 0x000182F2
		public unsafe Type MarshalTypeRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalTypeRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_MarshalTypeRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x0600449C RID: 17564 RVA: 0x0013C810 File Offset: 0x0013AA10
		// (set) Token: 0x0600449D RID: 17565 RVA: 0x0001A111 File Offset: 0x00018311
		public unsafe Type SafeArrayUserDefinedSubType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SafeArrayUserDefinedSubType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SafeArrayUserDefinedSubType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x0600449E RID: 17566 RVA: 0x0013C840 File Offset: 0x0013AA40
		// (set) Token: 0x0600449F RID: 17567 RVA: 0x0001A130 File Offset: 0x00018330
		public unsafe UnmanagedType utype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_utype);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_utype)) = value;
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x060044A0 RID: 17568 RVA: 0x0013C868 File Offset: 0x0013AA68
		// (set) Token: 0x060044A1 RID: 17569 RVA: 0x0001A14B File Offset: 0x0001834B
		public unsafe UnmanagedType ArraySubType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_ArraySubType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_ArraySubType)) = value;
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x060044A2 RID: 17570 RVA: 0x0013C890 File Offset: 0x0013AA90
		// (set) Token: 0x060044A3 RID: 17571 RVA: 0x0001A166 File Offset: 0x00018366
		public unsafe VarEnum SafeArraySubType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SafeArraySubType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SafeArraySubType)) = value;
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x060044A4 RID: 17572 RVA: 0x0013C8B8 File Offset: 0x0013AAB8
		// (set) Token: 0x060044A5 RID: 17573 RVA: 0x0001A181 File Offset: 0x00018381
		public unsafe int SizeConst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SizeConst);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SizeConst)) = value;
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x060044A6 RID: 17574 RVA: 0x0013C8E0 File Offset: 0x0013AAE0
		// (set) Token: 0x060044A7 RID: 17575 RVA: 0x0001A19C File Offset: 0x0001839C
		public unsafe int IidParameterIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_IidParameterIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_IidParameterIndex)) = value;
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x0013C908 File Offset: 0x0013AB08
		// (set) Token: 0x060044A9 RID: 17577 RVA: 0x0001A1B7 File Offset: 0x000183B7
		public unsafe short SizeParamIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SizeParamIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MarshalAsAttribute.NativeFieldInfoPtr_SizeParamIndex)) = value;
			}
		}

		// Token: 0x040037FA RID: 14330
		private static readonly IntPtr NativeFieldInfoPtr_MarshalCookie;

		// Token: 0x040037FB RID: 14331
		private static readonly IntPtr NativeFieldInfoPtr_MarshalType;

		// Token: 0x040037FC RID: 14332
		private static readonly IntPtr NativeFieldInfoPtr_MarshalTypeRef;

		// Token: 0x040037FD RID: 14333
		private static readonly IntPtr NativeFieldInfoPtr_SafeArrayUserDefinedSubType;

		// Token: 0x040037FE RID: 14334
		private static readonly IntPtr NativeFieldInfoPtr_utype;

		// Token: 0x040037FF RID: 14335
		private static readonly IntPtr NativeFieldInfoPtr_ArraySubType;

		// Token: 0x04003800 RID: 14336
		private static readonly IntPtr NativeFieldInfoPtr_SafeArraySubType;

		// Token: 0x04003801 RID: 14337
		private static readonly IntPtr NativeFieldInfoPtr_SizeConst;

		// Token: 0x04003802 RID: 14338
		private static readonly IntPtr NativeFieldInfoPtr_IidParameterIndex;

		// Token: 0x04003803 RID: 14339
		private static readonly IntPtr NativeFieldInfoPtr_SizeParamIndex;

		// Token: 0x04003804 RID: 14340
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_MarshalAsAttribute_0;
	}
}
