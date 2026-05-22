using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000C6 RID: 198
	public sealed class CreateAssetMenuAttribute : Attribute
	{
		// Token: 0x06001237 RID: 4663 RVA: 0x0004A7FC File Offset: 0x000489FC
		// Note: this type is marked as 'beforefieldinit'.
		static CreateAssetMenuAttribute()
		{
			Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CreateAssetMenuAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr);
			CreateAssetMenuAttribute.NativeFieldInfoPtr__menuName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, "<menuName>k__BackingField");
			CreateAssetMenuAttribute.NativeFieldInfoPtr__fileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, "<fileName>k__BackingField");
			CreateAssetMenuAttribute.NativeFieldInfoPtr__order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, "<order>k__BackingField");
			CreateAssetMenuAttribute.NativeMethodInfoPtr_set_menuName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100664821);
			CreateAssetMenuAttribute.NativeMethodInfoPtr_set_fileName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100664822);
			CreateAssetMenuAttribute.NativeMethodInfoPtr_set_order_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100664823);
			CreateAssetMenuAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100664824);
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x0000A89C File Offset: 0x00008A9C
		// (set) Token: 0x06001238 RID: 4664 RVA: 0x0004A8B8 File Offset: 0x00048AB8
		public unsafe string menuName
		{
			get
			{
				return this._menuName_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr_set_menuName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x0000A8A4 File Offset: 0x00008AA4
		// (set) Token: 0x06001239 RID: 4665 RVA: 0x0004A8FC File Offset: 0x00048AFC
		public unsafe string fileName
		{
			get
			{
				return this._fileName_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr_set_fileName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x0000A8AC File Offset: 0x00008AAC
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x0004A940 File Offset: 0x00048B40
		public unsafe int order
		{
			get
			{
				return this._order_k__BackingField;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr_set_order_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0004A980 File Offset: 0x00048B80
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateAssetMenuAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0000A83A File Offset: 0x00008A3A
		public CreateAssetMenuAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x0004A9BC File Offset: 0x00048BBC
		// (set) Token: 0x0600123E RID: 4670 RVA: 0x0000A843 File Offset: 0x00008A43
		public unsafe string _menuName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__menuName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__menuName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x0004A9E4 File Offset: 0x00048BE4
		// (set) Token: 0x06001240 RID: 4672 RVA: 0x0000A862 File Offset: 0x00008A62
		public unsafe string _fileName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__fileName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__fileName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x0004AA0C File Offset: 0x00048C0C
		// (set) Token: 0x06001242 RID: 4674 RVA: 0x0000A881 File Offset: 0x00008A81
		public unsafe int _order_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__order_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__order_k__BackingField)) = value;
			}
		}

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeFieldInfoPtr__menuName_k__BackingField;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeFieldInfoPtr__fileName_k__BackingField;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeFieldInfoPtr__order_k__BackingField;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeMethodInfoPtr_set_menuName_Public_set_Void_String_0;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr_set_fileName_Public_set_Void_String_0;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeMethodInfoPtr_set_order_Public_set_Void_Int32_0;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
