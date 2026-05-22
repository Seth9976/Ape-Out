using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel.Design.Serialization
{
	// Token: 0x0200009F RID: 159
	public sealed class RootDesignerSerializerAttribute : Attribute
	{
		// Token: 0x0600092F RID: 2351 RVA: 0x000327F8 File Offset: 0x000309F8
		// Note: this type is marked as 'beforefieldinit'.
		static RootDesignerSerializerAttribute()
		{
			Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel.Design.Serialization", "RootDesignerSerializerAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr);
			RootDesignerSerializerAttribute.NativeFieldInfoPtr_reloadable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr, "reloadable");
			RootDesignerSerializerAttribute.NativeFieldInfoPtr_serializerTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr, "serializerTypeName");
			RootDesignerSerializerAttribute.NativeFieldInfoPtr_serializerBaseTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr, "serializerBaseTypeName");
			RootDesignerSerializerAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr, 100664591);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00032878 File Offset: 0x00030A78
		[CallerCount(0)]
		public unsafe RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RootDesignerSerializerAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(serializerTypeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseSerializerTypeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reloadable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RootDesignerSerializerAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00005BE8 File Offset: 0x00003DE8
		public RootDesignerSerializerAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x000328E4 File Offset: 0x00030AE4
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x00005BF1 File Offset: 0x00003DF1
		public unsafe bool reloadable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootDesignerSerializerAttribute.NativeFieldInfoPtr_reloadable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootDesignerSerializerAttribute.NativeFieldInfoPtr_reloadable)) = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0003290C File Offset: 0x00030B0C
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x00005C0C File Offset: 0x00003E0C
		public unsafe string serializerTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootDesignerSerializerAttribute.NativeFieldInfoPtr_serializerTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootDesignerSerializerAttribute.NativeFieldInfoPtr_serializerTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00032934 File Offset: 0x00030B34
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00005C2B File Offset: 0x00003E2B
		public unsafe string serializerBaseTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootDesignerSerializerAttribute.NativeFieldInfoPtr_serializerBaseTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RootDesignerSerializerAttribute.NativeFieldInfoPtr_serializerBaseTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeFieldInfoPtr_reloadable;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeFieldInfoPtr_serializerTypeName;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeFieldInfoPtr_serializerBaseTypeName;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0;
	}
}
