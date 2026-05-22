using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200007B RID: 123
	public sealed class DesignerAttribute : Attribute
	{
		// Token: 0x06000847 RID: 2119 RVA: 0x0002FEC4 File Offset: 0x0002E0C4
		// Note: this type is marked as 'beforefieldinit'.
		static DesignerAttribute()
		{
			Il2CppClassPointerStore<DesignerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "DesignerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesignerAttribute>.NativeClassPtr);
			DesignerAttribute.NativeFieldInfoPtr_designerTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerAttribute>.NativeClassPtr, "designerTypeName");
			DesignerAttribute.NativeFieldInfoPtr_designerBaseTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerAttribute>.NativeClassPtr, "designerBaseTypeName");
			DesignerAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerAttribute>.NativeClassPtr, 100664504);
			DesignerAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerAttribute>.NativeClassPtr, 100664505);
			DesignerAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerAttribute>.NativeClassPtr, 100664506);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0002FF58 File Offset: 0x0002E158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372816, XrefRangeEnd = 372824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DesignerAttribute(string designerTypeName, Type designerBaseType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesignerAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(designerTypeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(designerBaseType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0002FFB8 File Offset: 0x0002E1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372824, XrefRangeEnd = 372826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00030008 File Offset: 0x0002E208
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0000543D File Offset: 0x0000363D
		public DesignerAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00030044 File Offset: 0x0002E244
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x00005446 File Offset: 0x00003646
		public unsafe string designerTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerAttribute.NativeFieldInfoPtr_designerTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerAttribute.NativeFieldInfoPtr_designerTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x0003006C File Offset: 0x0002E26C
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x00005465 File Offset: 0x00003665
		public unsafe string designerBaseTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerAttribute.NativeFieldInfoPtr_designerBaseTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerAttribute.NativeFieldInfoPtr_designerBaseTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeFieldInfoPtr_designerTypeName;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeFieldInfoPtr_designerBaseTypeName;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
