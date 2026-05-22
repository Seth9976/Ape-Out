using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000082 RID: 130
	public sealed class EditorBrowsableAttribute : Attribute
	{
		// Token: 0x06000885 RID: 2181 RVA: 0x00030A00 File Offset: 0x0002EC00
		// Note: this type is marked as 'beforefieldinit'.
		static EditorBrowsableAttribute()
		{
			Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "EditorBrowsableAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr);
			EditorBrowsableAttribute.NativeFieldInfoPtr_browsableState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr, "browsableState");
			EditorBrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_EditorBrowsableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr, 100664525);
			EditorBrowsableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr, 100664526);
			EditorBrowsableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr, 100664527);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00030A80 File Offset: 0x0002EC80
		[CallerCount(0)]
		public unsafe EditorBrowsableAttribute(EditorBrowsableState state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EditorBrowsableAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorBrowsableAttribute.NativeMethodInfoPtr__ctor_Public_Void_EditorBrowsableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00030AC8 File Offset: 0x0002ECC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372835, XrefRangeEnd = 372837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorBrowsableAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00030B18 File Offset: 0x0002ED18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorBrowsableAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00005619 File Offset: 0x00003819
		public EditorBrowsableAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00030B54 File Offset: 0x0002ED54
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00005622 File Offset: 0x00003822
		public unsafe EditorBrowsableState browsableState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorBrowsableAttribute.NativeFieldInfoPtr_browsableState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EditorBrowsableAttribute.NativeFieldInfoPtr_browsableState)) = value;
			}
		}

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeFieldInfoPtr_browsableState;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EditorBrowsableState_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
