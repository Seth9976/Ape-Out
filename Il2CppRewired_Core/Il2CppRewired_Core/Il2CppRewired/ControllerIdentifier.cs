using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired
{
	// Token: 0x02000015 RID: 21
	public sealed class ControllerIdentifier : ValueType
	{
		// Token: 0x06000195 RID: 405 RVA: 0x00033A84 File Offset: 0x00031C84
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerIdentifier()
		{
			Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired", "ControllerIdentifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr);
			ControllerIdentifier.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, "IfhnTjioRBhbGjEtsghiwZaIQGbU");
			ControllerIdentifier.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, "YgpbSyKqzywxZrpQdLClhHDXnpw");
			ControllerIdentifier.NativeFieldInfoPtr_fIcXfqCOzQsnxIOcRigOBZXpXnvF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, "fIcXfqCOzQsnxIOcRigOBZXpXnvF");
			ControllerIdentifier.NativeFieldInfoPtr_jdcPETmMIvMmHVnMHCJJTSjrSqP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, "jdcPETmMIvMmHVnMHCJJTSjrSqP");
			ControllerIdentifier.NativeFieldInfoPtr_eQJBlDDZPAKtTdYDEAPfLSqyIfwd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, "eQJBlDDZPAKtTdYDEAPfLSqyIfwd");
			ControllerIdentifier.NativeMethodInfoPtr__ctor_Internal_Void_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, 100663558);
			ControllerIdentifier.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, 100663559);
			ControllerIdentifier.NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, 100663560);
			ControllerIdentifier.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, 100663561);
			ControllerIdentifier.NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, 100663562);
			ControllerIdentifier.NativeMethodInfoPtr_get_hardwareTypeGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, 100663563);
			ControllerIdentifier.NativeMethodInfoPtr_set_hardwareTypeGuid_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, 100663564);
			ControllerIdentifier.NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, 100663565);
			ControllerIdentifier.NativeMethodInfoPtr_set_hardwareIdentifier_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, 100663566);
			ControllerIdentifier.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, 100663567);
			ControllerIdentifier.NativeMethodInfoPtr_set_deviceInstanceGuid_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, 100663568);
			ControllerIdentifier.NativeMethodInfoPtr_get_Blank_Public_Static_get_ControllerIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr, 100663569);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00033C08 File Offset: 0x00031E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243410, XrefRangeEnd = 243412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControllerIdentifier(Controller controller)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerIdentifier.NativeMethodInfoPtr__ctor_Internal_Void_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00033C58 File Offset: 0x00031E58
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00033C9C File Offset: 0x00031E9C
		public unsafe int controllerId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerIdentifier.NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerIdentifier.NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00033CE0 File Offset: 0x00031EE0
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00033D24 File Offset: 0x00031F24
		public unsafe ControllerType controllerType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerIdentifier.NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerIdentifier.NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00033D68 File Offset: 0x00031F68
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00033DAC File Offset: 0x00031FAC
		public unsafe Guid hardwareTypeGuid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerIdentifier.NativeMethodInfoPtr_get_hardwareTypeGuid_Public_get_Guid_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerIdentifier.NativeMethodInfoPtr_set_hardwareTypeGuid_Public_set_Void_Guid_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00033DF0 File Offset: 0x00031FF0
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00033E2C File Offset: 0x0003202C
		public unsafe string hardwareIdentifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerIdentifier.NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerIdentifier.NativeMethodInfoPtr_set_hardwareIdentifier_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00033E74 File Offset: 0x00032074
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00033EB8 File Offset: 0x000320B8
		public unsafe Guid deviceInstanceGuid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerIdentifier.NativeMethodInfoPtr_get_deviceInstanceGuid_Public_get_Guid_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerIdentifier.NativeMethodInfoPtr_set_deviceInstanceGuid_Public_set_Void_Guid_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00033EFC File Offset: 0x000320FC
		public unsafe static ControllerIdentifier Blank
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerIdentifier.NativeMethodInfoPtr_get_Blank_Public_Static_get_ControllerIdentifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ControllerIdentifier(intPtr);
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002726 File Offset: 0x00000926
		public ControllerIdentifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000272F File Offset: 0x0000092F
		public ControllerIdentifier()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerIdentifier>.NativeClassPtr))
		{
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00033F28 File Offset: 0x00032128
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002741 File Offset: 0x00000941
		public unsafe int IfhnTjioRBhbGjEtsghiwZaIQGbU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerIdentifier.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerIdentifier.NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU)) = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00033F50 File Offset: 0x00032150
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x0000275C File Offset: 0x0000095C
		public unsafe ControllerType YgpbSyKqzywxZrpQdLClhHDXnpw
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerIdentifier.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerIdentifier.NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00033F78 File Offset: 0x00032178
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00002777 File Offset: 0x00000977
		public unsafe Guid fIcXfqCOzQsnxIOcRigOBZXpXnvF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerIdentifier.NativeFieldInfoPtr_fIcXfqCOzQsnxIOcRigOBZXpXnvF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerIdentifier.NativeFieldInfoPtr_fIcXfqCOzQsnxIOcRigOBZXpXnvF)) = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00033FA0 File Offset: 0x000321A0
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00002792 File Offset: 0x00000992
		public unsafe string jdcPETmMIvMmHVnMHCJJTSjrSqP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerIdentifier.NativeFieldInfoPtr_jdcPETmMIvMmHVnMHCJJTSjrSqP);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerIdentifier.NativeFieldInfoPtr_jdcPETmMIvMmHVnMHCJJTSjrSqP), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00033FC8 File Offset: 0x000321C8
		// (set) Token: 0x060001AD RID: 429 RVA: 0x000027B1 File Offset: 0x000009B1
		public unsafe Guid eQJBlDDZPAKtTdYDEAPfLSqyIfwd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerIdentifier.NativeFieldInfoPtr_eQJBlDDZPAKtTdYDEAPfLSqyIfwd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControllerIdentifier.NativeFieldInfoPtr_eQJBlDDZPAKtTdYDEAPfLSqyIfwd)) = value;
			}
		}

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_IfhnTjioRBhbGjEtsghiwZaIQGbU;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_YgpbSyKqzywxZrpQdLClhHDXnpw;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_fIcXfqCOzQsnxIOcRigOBZXpXnvF;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_jdcPETmMIvMmHVnMHCJJTSjrSqP;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_eQJBlDDZPAKtTdYDEAPfLSqyIfwd;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Controller_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerId_Public_get_Int32_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerId_Public_set_Void_Int32_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_get_controllerType_Public_get_ControllerType_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_set_controllerType_Public_set_Void_ControllerType_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareTypeGuid_Public_get_Guid_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr_set_hardwareTypeGuid_Public_set_Void_Guid_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_get_hardwareIdentifier_Public_get_String_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_set_hardwareIdentifier_Public_set_Void_String_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_get_deviceInstanceGuid_Public_get_Guid_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_set_deviceInstanceGuid_Public_set_Void_Guid_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_get_Blank_Public_Static_get_ControllerIdentifier_0;
	}
}
