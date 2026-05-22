using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035E RID: 862
	public sealed class BinaryCrossAppDomainMap : Object
	{
		// Token: 0x060037E2 RID: 14306 RVA: 0x001103D0 File Offset: 0x0010E5D0
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryCrossAppDomainMap()
		{
			Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryCrossAppDomainMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr);
			BinaryCrossAppDomainMap.NativeFieldInfoPtr_crossAppDomainArrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr, "crossAppDomainArrayIndex");
			BinaryCrossAppDomainMap.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr, 100671913);
			BinaryCrossAppDomainMap.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr, 100671914);
			BinaryCrossAppDomainMap.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr, 100671915);
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x00110450 File Offset: 0x0010E650
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryCrossAppDomainMap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryCrossAppDomainMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainMap.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x0011048C File Offset: 0x0010E68C
		[CallerCount(0)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainMap.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x001104D0 File Offset: 0x0010E6D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryCrossAppDomainMap.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x00013FA4 File Offset: 0x000121A4
		public BinaryCrossAppDomainMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x060037E7 RID: 14311 RVA: 0x00110504 File Offset: 0x0010E704
		// (set) Token: 0x060037E8 RID: 14312 RVA: 0x00013FAD File Offset: 0x000121AD
		public unsafe int crossAppDomainArrayIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainMap.NativeFieldInfoPtr_crossAppDomainArrayIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryCrossAppDomainMap.NativeFieldInfoPtr_crossAppDomainArrayIndex)) = value;
			}
		}

		// Token: 0x04002EEC RID: 12012
		private static readonly IntPtr NativeFieldInfoPtr_crossAppDomainArrayIndex;

		// Token: 0x04002EED RID: 12013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002EEE RID: 12014
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002EEF RID: 12015
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
