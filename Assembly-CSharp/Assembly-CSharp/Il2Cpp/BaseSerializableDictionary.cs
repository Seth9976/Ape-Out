using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x02000021 RID: 33
	public class BaseSerializableDictionary : Object
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x0003FD5C File Offset: 0x0003DF5C
		// Note: this type is marked as 'beforefieldinit'.
		static BaseSerializableDictionary()
		{
			Il2CppClassPointerStore<BaseSerializableDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BaseSerializableDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseSerializableDictionary>.NativeClassPtr);
			BaseSerializableDictionary.NativeFieldInfoPtr_keyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSerializableDictionary>.NativeClassPtr, "keyName");
			BaseSerializableDictionary.NativeFieldInfoPtr_valueName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSerializableDictionary>.NativeClassPtr, "valueName");
			BaseSerializableDictionary.NativeFieldInfoPtr_newKeyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSerializableDictionary>.NativeClassPtr, "newKeyName");
			BaseSerializableDictionary.NativeFieldInfoPtr_drawSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSerializableDictionary>.NativeClassPtr, "drawSelection");
			BaseSerializableDictionary.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSerializableDictionary>.NativeClassPtr, 100663601);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0003FDF0 File Offset: 0x0003DFF0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 34788, RefRangeEnd = 34793, XrefRangeStart = 34782, XrefRangeEnd = 34788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseSerializableDictionary(string keyName = "Key", string valueName = "Value", string newKeyName = "New Key")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseSerializableDictionary>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newKeyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseSerializableDictionary.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00004C41 File Offset: 0x00002E41
		public BaseSerializableDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0003FE60 File Offset: 0x0003E060
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00004C4A File Offset: 0x00002E4A
		public unsafe string keyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSerializableDictionary.NativeFieldInfoPtr_keyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSerializableDictionary.NativeFieldInfoPtr_keyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0003FE88 File Offset: 0x0003E088
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x00004C69 File Offset: 0x00002E69
		public unsafe string valueName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSerializableDictionary.NativeFieldInfoPtr_valueName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSerializableDictionary.NativeFieldInfoPtr_valueName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0003FEB0 File Offset: 0x0003E0B0
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x00004C88 File Offset: 0x00002E88
		public unsafe string newKeyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSerializableDictionary.NativeFieldInfoPtr_newKeyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSerializableDictionary.NativeFieldInfoPtr_newKeyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0003FED8 File Offset: 0x0003E0D8
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x00004CA7 File Offset: 0x00002EA7
		public unsafe bool drawSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSerializableDictionary.NativeFieldInfoPtr_drawSelection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseSerializableDictionary.NativeFieldInfoPtr_drawSelection)) = value;
			}
		}

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr_keyName;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_valueName;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_newKeyName;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr_drawSelection;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;
	}
}
