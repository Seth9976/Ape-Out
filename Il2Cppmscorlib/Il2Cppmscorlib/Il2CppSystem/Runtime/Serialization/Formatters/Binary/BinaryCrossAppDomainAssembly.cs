using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000358 RID: 856
	public sealed class BinaryCrossAppDomainAssembly : Object
	{
		// Token: 0x06003792 RID: 14226 RVA: 0x0010F600 File Offset: 0x0010D800
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCrossAppDomainAssembly()
		{
			Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryCrossAppDomainAssembly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr);
			BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, "assemId");
			BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemblyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, "assemblyIndex");
			BinaryCrossAppDomainAssembly.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, 100671890);
			BinaryCrossAppDomainAssembly.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, 100671891);
			BinaryCrossAppDomainAssembly.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr, 100671892);
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x0010F694 File Offset: 0x0010D894
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryCrossAppDomainAssembly()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryCrossAppDomainAssembly>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainAssembly.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x0010F6D0 File Offset: 0x0010D8D0
		[CallerCount(0)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainAssembly.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x0010F714 File Offset: 0x0010D914
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainAssembly.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x00013CDE File Offset: 0x00011EDE
		public BinaryCrossAppDomainAssembly(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06003797 RID: 14231 RVA: 0x0010F748 File Offset: 0x0010D948
		// (set) Token: 0x06003798 RID: 14232 RVA: 0x00013CE7 File Offset: 0x00011EE7
		public unsafe int assemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemId)) = value;
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06003799 RID: 14233 RVA: 0x0010F770 File Offset: 0x0010D970
		// (set) Token: 0x0600379A RID: 14234 RVA: 0x00013D02 File Offset: 0x00011F02
		public unsafe int assemblyIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemblyIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainAssembly.NativeFieldInfoPtr_assemblyIndex)) = value;
			}
		}

		// Token: 0x04002EBF RID: 11967
		private static readonly IntPtr NativeFieldInfoPtr_assemId;

		// Token: 0x04002EC0 RID: 11968
		private static readonly IntPtr NativeFieldInfoPtr_assemblyIndex;

		// Token: 0x04002EC1 RID: 11969
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002EC2 RID: 11970
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002EC3 RID: 11971
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
