using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000359 RID: 857
	public sealed class BinaryObject : Object
	{
		// Token: 0x0600379B RID: 14235 RVA: 0x0010F798 File Offset: 0x0010D998
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryObject()
		{
			Il2CppClassPointerStore<BinaryObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr);
			BinaryObject.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, "objectId");
			BinaryObject.NativeFieldInfoPtr_mapId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, "mapId");
			BinaryObject.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671893);
			BinaryObject.NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671894);
			BinaryObject.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671895);
			BinaryObject.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671896);
			BinaryObject.NativeMethodInfoPtr_Dump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr, 100671897);
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x0010F854 File Offset: 0x0010DA54
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x0010F890 File Offset: 0x0010DA90
		[CallerCount(0)]
		public unsafe void Set(int objectId, int mapId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mapId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x0010F8DC File Offset: 0x0010DADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215800, XrefRangeEnd = 215801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Write(__BinaryWriter sout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sout);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x0010F920 File Offset: 0x0010DB20
		[CallerCount(0)]
		public unsafe void Read(__BinaryParser input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x0010F964 File Offset: 0x0010DB64
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryObject.NativeMethodInfoPtr_Dump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x00013D1D File Offset: 0x00011F1D
		public BinaryObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x060037A2 RID: 14242 RVA: 0x0010F998 File Offset: 0x0010DB98
		// (set) Token: 0x060037A3 RID: 14243 RVA: 0x00013D26 File Offset: 0x00011F26
		public unsafe int objectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObject.NativeFieldInfoPtr_objectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObject.NativeFieldInfoPtr_objectId)) = value;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x060037A4 RID: 14244 RVA: 0x0010F9C0 File Offset: 0x0010DBC0
		// (set) Token: 0x060037A5 RID: 14245 RVA: 0x00013D41 File Offset: 0x00011F41
		public unsafe int mapId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObject.NativeFieldInfoPtr_mapId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryObject.NativeFieldInfoPtr_mapId)) = value;
			}
		}

		// Token: 0x04002EC4 RID: 11972
		private static readonly IntPtr NativeFieldInfoPtr_objectId;

		// Token: 0x04002EC5 RID: 11973
		private static readonly IntPtr NativeFieldInfoPtr_mapId;

		// Token: 0x04002EC6 RID: 11974
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002EC7 RID: 11975
		private static readonly IntPtr NativeMethodInfoPtr_Set_Internal_Void_Int32_Int32_0;

		// Token: 0x04002EC8 RID: 11976
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Final_New_Void___BinaryWriter_0;

		// Token: 0x04002EC9 RID: 11977
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Final_New_Void___BinaryParser_0;

		// Token: 0x04002ECA RID: 11978
		private static readonly IntPtr NativeMethodInfoPtr_Dump_Public_Void_0;
	}
}
