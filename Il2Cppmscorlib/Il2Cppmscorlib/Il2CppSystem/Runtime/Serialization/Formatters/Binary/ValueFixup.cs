using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000387 RID: 903
	public sealed class ValueFixup : Object
	{
		// Token: 0x06003BBB RID: 15291 RVA: 0x0011D104 File Offset: 0x0011B304
		// Note: this type is marked as 'beforefieldinit'.
		static ValueFixup()
		{
			Il2CppClassPointerStore<ValueFixup>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ValueFixup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr);
			ValueFixup.NativeFieldInfoPtr_valueFixupEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "valueFixupEnum");
			ValueFixup.NativeFieldInfoPtr_arrayObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "arrayObj");
			ValueFixup.NativeFieldInfoPtr_indexMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "indexMap");
			ValueFixup.NativeFieldInfoPtr_header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "header");
			ValueFixup.NativeFieldInfoPtr_memberObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "memberObject");
			ValueFixup.NativeFieldInfoPtr_valueInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "valueInfo");
			ValueFixup.NativeFieldInfoPtr_objectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "objectInfo");
			ValueFixup.NativeFieldInfoPtr_memberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, "memberName");
			ValueFixup.NativeMethodInfoPtr__ctor_Internal_Void_Array_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, 100672233);
			ValueFixup.NativeMethodInfoPtr__ctor_Internal_Void_Object_String_ReadObjectInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, 100672234);
			ValueFixup.NativeMethodInfoPtr_Fixup_Internal_Void_ParseRecord_ParseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr, 100672235);
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x0011D210 File Offset: 0x0011B410
		[CallerCount(0)]
		public unsafe ValueFixup(Array arrayObj, Il2CppStructArray<int> indexMap)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arrayObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexMap);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueFixup.NativeMethodInfoPtr__ctor_Internal_Void_Array_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x0011D270 File Offset: 0x0011B470
		[CallerCount(0)]
		public unsafe ValueFixup(Object memberObject, string memberName, ReadObjectInfo objectInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueFixup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(memberObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(memberName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueFixup.NativeMethodInfoPtr__ctor_Internal_Void_Object_String_ReadObjectInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x0011D2E0 File Offset: 0x0011B4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218994, XrefRangeEnd = 219002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fixup(ParseRecord record, ParseRecord parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueFixup.NativeMethodInfoPtr_Fixup_Internal_Void_ParseRecord_ParseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BBF RID: 15295 RVA: 0x00016220 File Offset: 0x00014420
		public ValueFixup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06003BC0 RID: 15296 RVA: 0x0011D334 File Offset: 0x0011B534
		// (set) Token: 0x06003BC1 RID: 15297 RVA: 0x00016229 File Offset: 0x00014429
		public unsafe ValueFixupEnum valueFixupEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_valueFixupEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_valueFixupEnum)) = value;
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06003BC2 RID: 15298 RVA: 0x0011D35C File Offset: 0x0011B55C
		// (set) Token: 0x06003BC3 RID: 15299 RVA: 0x00016244 File Offset: 0x00014444
		public unsafe Array arrayObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_arrayObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_arrayObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06003BC4 RID: 15300 RVA: 0x0011D38C File Offset: 0x0011B58C
		// (set) Token: 0x06003BC5 RID: 15301 RVA: 0x00016263 File Offset: 0x00014463
		public unsafe Il2CppStructArray<int> indexMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_indexMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_indexMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06003BC6 RID: 15302 RVA: 0x0011D3BC File Offset: 0x0011B5BC
		// (set) Token: 0x06003BC7 RID: 15303 RVA: 0x00016282 File Offset: 0x00014482
		public unsafe Object header
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_header);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_header), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06003BC8 RID: 15304 RVA: 0x0011D3EC File Offset: 0x0011B5EC
		// (set) Token: 0x06003BC9 RID: 15305 RVA: 0x000162A1 File Offset: 0x000144A1
		public unsafe Object memberObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_memberObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_memberObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x06003BCA RID: 15306 RVA: 0x0011D41C File Offset: 0x0011B61C
		// (set) Token: 0x06003BCB RID: 15307 RVA: 0x000162C0 File Offset: 0x000144C0
		public unsafe static MemberInfo valueInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValueFixup.NativeFieldInfoPtr_valueInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValueFixup.NativeFieldInfoPtr_valueInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06003BCC RID: 15308 RVA: 0x0011D444 File Offset: 0x0011B644
		// (set) Token: 0x06003BCD RID: 15309 RVA: 0x000162D2 File Offset: 0x000144D2
		public unsafe ReadObjectInfo objectInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_objectInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_objectInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06003BCE RID: 15310 RVA: 0x0011D474 File Offset: 0x0011B674
		// (set) Token: 0x06003BCF RID: 15311 RVA: 0x000162F1 File Offset: 0x000144F1
		public unsafe string memberName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_memberName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValueFixup.NativeFieldInfoPtr_memberName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040031D4 RID: 12756
		private static readonly IntPtr NativeFieldInfoPtr_valueFixupEnum;

		// Token: 0x040031D5 RID: 12757
		private static readonly IntPtr NativeFieldInfoPtr_arrayObj;

		// Token: 0x040031D6 RID: 12758
		private static readonly IntPtr NativeFieldInfoPtr_indexMap;

		// Token: 0x040031D7 RID: 12759
		private static readonly IntPtr NativeFieldInfoPtr_header;

		// Token: 0x040031D8 RID: 12760
		private static readonly IntPtr NativeFieldInfoPtr_memberObject;

		// Token: 0x040031D9 RID: 12761
		private static readonly IntPtr NativeFieldInfoPtr_valueInfo;

		// Token: 0x040031DA RID: 12762
		private static readonly IntPtr NativeFieldInfoPtr_objectInfo;

		// Token: 0x040031DB RID: 12763
		private static readonly IntPtr NativeFieldInfoPtr_memberName;

		// Token: 0x040031DC RID: 12764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Array_Il2CppStructArray_1_Int32_0;

		// Token: 0x040031DD RID: 12765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_String_ReadObjectInfo_0;

		// Token: 0x040031DE RID: 12766
		private static readonly IntPtr NativeMethodInfoPtr_Fixup_Internal_Void_ParseRecord_ParseRecord_0;
	}
}
