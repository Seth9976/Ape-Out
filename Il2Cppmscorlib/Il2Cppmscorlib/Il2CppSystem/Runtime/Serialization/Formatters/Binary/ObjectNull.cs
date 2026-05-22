using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000365 RID: 869
	public sealed class ObjectNull : Object
	{
		// Token: 0x0600384F RID: 14415 RVA: 0x00111930 File Offset: 0x0010FB30
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectNull()
		{
			Il2CppClassPointerStore<ObjectNull>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ObjectNull");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr);
			ObjectNull.NativeFieldInfoPtr_nullCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, "nullCount");
			ObjectNull.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671948);
			ObjectNull.NativeMethodInfoPtr_SetNullCount_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671949);
			ObjectNull.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671950);
			ObjectNull.NativeMethodInfoPtr_Read_Public_Void___BinaryParser_BinaryHeaderEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671951);
			ObjectNull.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr, 100671952);
		}

		// Token: 0x06003850 RID: 14416 RVA: 0x001119D8 File Offset: 0x0010FBD8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectNull()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectNull>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003851 RID: 14417 RVA: 0x00111A14 File Offset: 0x0010FC14
		[CallerCount(0)]
		public unsafe void SetNullCount(int nullCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nullCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr_SetNullCount_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x00111A54 File Offset: 0x0010FC54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 215901, RefRangeEnd = 215905, XrefRangeStart = 215900, XrefRangeEnd = 215901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x00111A98 File Offset: 0x0010FC98
		[CallerCount(0)]
		public unsafe void Read(__BinaryParser input, BinaryHeaderEnum binaryHeaderEnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref binaryHeaderEnum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr_Read_Public_Void___BinaryParser_BinaryHeaderEnum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x00111AE8 File Offset: 0x0010FCE8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectNull.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x0001433D File Offset: 0x0001253D
		public ObjectNull(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06003856 RID: 14422 RVA: 0x00111B1C File Offset: 0x0010FD1C
		// (set) Token: 0x06003857 RID: 14423 RVA: 0x00014346 File Offset: 0x00012546
		public unsafe int nullCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectNull.NativeFieldInfoPtr_nullCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectNull.NativeFieldInfoPtr_nullCount)) = value;
			}
		}

		// Token: 0x04002F2D RID: 12077
		private static readonly IntPtr NativeFieldInfoPtr_nullCount;

		// Token: 0x04002F2E RID: 12078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002F2F RID: 12079
		private static readonly IntPtr NativeMethodInfoPtr_SetNullCount_Internal_Void_Int32_0;

		// Token: 0x04002F30 RID: 12080
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002F31 RID: 12081
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Void___BinaryParser_BinaryHeaderEnum_0;

		// Token: 0x04002F32 RID: 12082
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
