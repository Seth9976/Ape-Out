using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035F RID: 863
	public sealed class MemberPrimitiveTyped : Object
	{
		// Token: 0x060037E9 RID: 14313 RVA: 0x0011052C File Offset: 0x0010E72C
		// Note: this type is marked as 'beforefieldinit'.
		static MemberPrimitiveTyped()
		{
			Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "MemberPrimitiveTyped");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr);
			MemberPrimitiveTyped.NativeFieldInfoPtr_primitiveTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, "primitiveTypeEnum");
			MemberPrimitiveTyped.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, "value");
			MemberPrimitiveTyped.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671916);
			MemberPrimitiveTyped.NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671917);
			MemberPrimitiveTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671918);
			MemberPrimitiveTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671919);
			MemberPrimitiveTyped.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr, 100671920);
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x001105E8 File Offset: 0x0010E7E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberPrimitiveTyped()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberPrimitiveTyped>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x00110624 File Offset: 0x0010E824
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106068, RefRangeEnd = 106070, XrefRangeStart = 106068, XrefRangeEnd = 106070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(InternalPrimitiveTypeE primitiveTypeEnum, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref primitiveTypeEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x00110674 File Offset: 0x0010E874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215837, XrefRangeEnd = 215839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x001106B8 File Offset: 0x0010E8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215839, XrefRangeEnd = 215840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x001106FC File Offset: 0x0010E8FC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberPrimitiveTyped.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x00013FC8 File Offset: 0x000121C8
		public MemberPrimitiveTyped(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x060037F0 RID: 14320 RVA: 0x00110730 File Offset: 0x0010E930
		// (set) Token: 0x060037F1 RID: 14321 RVA: 0x00013FD1 File Offset: 0x000121D1
		public unsafe InternalPrimitiveTypeE primitiveTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveTyped.NativeFieldInfoPtr_primitiveTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveTyped.NativeFieldInfoPtr_primitiveTypeEnum)) = value;
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x060037F2 RID: 14322 RVA: 0x00110758 File Offset: 0x0010E958
		// (set) Token: 0x060037F3 RID: 14323 RVA: 0x00013FEC File Offset: 0x000121EC
		public unsafe Object value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveTyped.NativeFieldInfoPtr_value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberPrimitiveTyped.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EF0 RID: 12016
		private static readonly IntPtr NativeFieldInfoPtr_primitiveTypeEnum;

		// Token: 0x04002EF1 RID: 12017
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04002EF2 RID: 12018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002EF3 RID: 12019
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_InternalPrimitiveTypeE_Object_0;

		// Token: 0x04002EF4 RID: 12020
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002EF5 RID: 12021
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002EF6 RID: 12022
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
