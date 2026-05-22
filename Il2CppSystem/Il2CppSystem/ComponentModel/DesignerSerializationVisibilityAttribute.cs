using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200007E RID: 126
	public sealed class DesignerSerializationVisibilityAttribute : Attribute
	{
		// Token: 0x06000860 RID: 2144 RVA: 0x00030354 File Offset: 0x0002E554
		// Note: this type is marked as 'beforefieldinit'.
		static DesignerSerializationVisibilityAttribute()
		{
			Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "DesignerSerializationVisibilityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr);
			DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, "Content");
			DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Hidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, "Hidden");
			DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, "Visible");
			DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, "Default");
			DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, "visibility");
			DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_DesignerSerializationVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, 100664512);
			DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr_get_Visibility_Public_get_DesignerSerializationVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, 100664513);
			DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, 100664514);
			DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr, 100664515);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00030438 File Offset: 0x0002E638
		[CallerCount(0)]
		public unsafe DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DesignerSerializationVisibilityAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visibility;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_DesignerSerializationVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x00030480 File Offset: 0x0002E680
		public unsafe DesignerSerializationVisibility Visibility
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr_get_Visibility_Public_get_DesignerSerializationVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x000304BC File Offset: 0x0002E6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372830, XrefRangeEnd = 372832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0003050C File Offset: 0x0002E70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DesignerSerializationVisibilityAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000054F4 File Offset: 0x000036F4
		public DesignerSerializationVisibilityAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00030548 File Offset: 0x0002E748
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x000054FD File Offset: 0x000036FD
		public unsafe static DesignerSerializationVisibilityAttribute Content
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Content, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerSerializationVisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Content, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00030570 File Offset: 0x0002E770
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x0000550F File Offset: 0x0000370F
		public unsafe static DesignerSerializationVisibilityAttribute Hidden
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Hidden, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerSerializationVisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Hidden, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00030598 File Offset: 0x0002E798
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00005521 File Offset: 0x00003721
		public unsafe static DesignerSerializationVisibilityAttribute Visible
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Visible, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerSerializationVisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Visible, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x000305C0 File Offset: 0x0002E7C0
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x00005533 File Offset: 0x00003733
		public unsafe static DesignerSerializationVisibilityAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DesignerSerializationVisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x000305E8 File Offset: 0x0002E7E8
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x00005545 File Offset: 0x00003745
		public unsafe DesignerSerializationVisibility visibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_visibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DesignerSerializationVisibilityAttribute.NativeFieldInfoPtr_visibility)) = value;
			}
		}

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeFieldInfoPtr_Content;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeFieldInfoPtr_Hidden;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeFieldInfoPtr_Visible;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeFieldInfoPtr_visibility;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DesignerSerializationVisibility_0;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeMethodInfoPtr_get_Visibility_Public_get_DesignerSerializationVisibility_0;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
