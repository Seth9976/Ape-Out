using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Bindings
{
	// Token: 0x02000018 RID: 24
	public class StaticAccessorAttribute : Attribute
	{
		// Token: 0x0600009A RID: 154 RVA: 0x0000403C File Offset: 0x0000223C
		// Note: this type is marked as 'beforefieldinit'.
		static StaticAccessorAttribute()
		{
			Il2CppClassPointerStore<StaticAccessorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "StaticAccessorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StaticAccessorAttribute>.NativeClassPtr);
			StaticAccessorAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticAccessorAttribute>.NativeClassPtr, "<Name>k__BackingField");
			StaticAccessorAttribute.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StaticAccessorAttribute>.NativeClassPtr, "<Type>k__BackingField");
			StaticAccessorAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticAccessorAttribute>.NativeClassPtr, 100663347);
			StaticAccessorAttribute.NativeMethodInfoPtr_set_Type_Public_set_Void_StaticAccessorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticAccessorAttribute>.NativeClassPtr, 100663348);
			StaticAccessorAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticAccessorAttribute>.NativeClassPtr, 100663349);
			StaticAccessorAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_StaticAccessorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StaticAccessorAttribute>.NativeClassPtr, 100663350);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000025FE File Offset: 0x000007FE
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000040E4 File Offset: 0x000022E4
		public unsafe string Name
		{
			get
			{
				return this._Name_k__BackingField;
			}
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticAccessorAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002606 File Offset: 0x00000806
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00004128 File Offset: 0x00002328
		public unsafe StaticAccessorType Type
		{
			get
			{
				return this._Type_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticAccessorAttribute.NativeMethodInfoPtr_set_Type_Public_set_Void_StaticAccessorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004168 File Offset: 0x00002368
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticAccessorAttribute(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticAccessorAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticAccessorAttribute.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000041B4 File Offset: 0x000023B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 22674, RefRangeEnd = 22677, XrefRangeStart = 22674, XrefRangeEnd = 22677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticAccessorAttribute(string name, StaticAccessorType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StaticAccessorAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StaticAccessorAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_StaticAccessorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000025BB File Offset: 0x000007BB
		public StaticAccessorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00004210 File Offset: 0x00002410
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x000025C4 File Offset: 0x000007C4
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticAccessorAttribute.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticAccessorAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00004238 File Offset: 0x00002438
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000025E3 File Offset: 0x000007E3
		public unsafe StaticAccessorType _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticAccessorAttribute.NativeFieldInfoPtr__Type_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StaticAccessorAttribute.NativeFieldInfoPtr__Type_k__BackingField)) = value;
			}
		}

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_StaticAccessorType_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_StaticAccessorType_0;
	}
}
