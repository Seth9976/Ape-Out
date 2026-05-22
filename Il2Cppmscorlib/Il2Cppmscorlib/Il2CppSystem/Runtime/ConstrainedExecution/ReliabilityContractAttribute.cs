using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.ConstrainedExecution
{
	// Token: 0x02000412 RID: 1042
	public sealed class ReliabilityContractAttribute : Attribute
	{
		// Token: 0x0600427E RID: 17022 RVA: 0x0013515C File Offset: 0x0013335C
		// Note: this type is marked as 'beforefieldinit'.
		static ReliabilityContractAttribute()
		{
			Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ConstrainedExecution", "ReliabilityContractAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr);
			ReliabilityContractAttribute.NativeFieldInfoPtr__consistency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr, "_consistency");
			ReliabilityContractAttribute.NativeFieldInfoPtr__cer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr, "_cer");
			ReliabilityContractAttribute.NativeMethodInfoPtr__ctor_Public_Void_Consistency_Cer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr, 100673028);
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x001351C8 File Offset: 0x001333C8
		[CallerCount(0)]
		public unsafe ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReliabilityContractAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref consistencyGuarantee;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReliabilityContractAttribute.NativeMethodInfoPtr__ctor_Public_Void_Consistency_Cer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x00019189 File Offset: 0x00017389
		public ReliabilityContractAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x06004281 RID: 17025 RVA: 0x00135220 File Offset: 0x00133420
		// (set) Token: 0x06004282 RID: 17026 RVA: 0x00019192 File Offset: 0x00017392
		public unsafe Consistency _consistency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReliabilityContractAttribute.NativeFieldInfoPtr__consistency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReliabilityContractAttribute.NativeFieldInfoPtr__consistency)) = value;
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06004283 RID: 17027 RVA: 0x00135248 File Offset: 0x00133448
		// (set) Token: 0x06004284 RID: 17028 RVA: 0x000191AD File Offset: 0x000173AD
		public unsafe Cer _cer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReliabilityContractAttribute.NativeFieldInfoPtr__cer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReliabilityContractAttribute.NativeFieldInfoPtr__cer)) = value;
			}
		}

		// Token: 0x04003640 RID: 13888
		private static readonly IntPtr NativeFieldInfoPtr__consistency;

		// Token: 0x04003641 RID: 13889
		private static readonly IntPtr NativeFieldInfoPtr__cer;

		// Token: 0x04003642 RID: 13890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Consistency_Cer_0;
	}
}
