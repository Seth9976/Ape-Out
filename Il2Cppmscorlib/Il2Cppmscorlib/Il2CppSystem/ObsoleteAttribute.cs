using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000D7 RID: 215
	[Serializable]
	public sealed class ObsoleteAttribute : Attribute
	{
		// Token: 0x06000E7B RID: 3707 RVA: 0x00065D34 File Offset: 0x00063F34
		// Note: this type is marked as 'beforefieldinit'.
		static ObsoleteAttribute()
		{
			Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ObsoleteAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr);
			ObsoleteAttribute.NativeFieldInfoPtr__message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, "_message");
			ObsoleteAttribute.NativeFieldInfoPtr__error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, "_error");
			ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, 100665768);
			ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, 100665769);
			ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, 100665770);
			ObsoleteAttribute.NativeMethodInfoPtr_get_Message_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr, 100665771);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00065DDC File Offset: 0x00063FDC
		[CallerCount(0)]
		public unsafe ObsoleteAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00065E18 File Offset: 0x00064018
		[CallerCount(0)]
		public unsafe ObsoleteAttribute(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00065E64 File Offset: 0x00064064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161220, RefRangeEnd = 161221, XrefRangeStart = 161220, XrefRangeEnd = 161220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObsoleteAttribute(string message, bool error)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObsoleteAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObsoleteAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x00065EC0 File Offset: 0x000640C0
		public unsafe string Message
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObsoleteAttribute.NativeMethodInfoPtr_get_Message_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00005A91 File Offset: 0x00003C91
		public ObsoleteAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x00065EF8 File Offset: 0x000640F8
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x00005A9A File Offset: 0x00003C9A
		public unsafe string _message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObsoleteAttribute.NativeFieldInfoPtr__message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObsoleteAttribute.NativeFieldInfoPtr__message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x00065F20 File Offset: 0x00064120
		// (set) Token: 0x06000E84 RID: 3716 RVA: 0x00005AB9 File Offset: 0x00003CB9
		public unsafe bool _error
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObsoleteAttribute.NativeFieldInfoPtr__error);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObsoleteAttribute.NativeFieldInfoPtr__error)) = value;
			}
		}

		// Token: 0x04000C51 RID: 3153
		private static readonly IntPtr NativeFieldInfoPtr__message;

		// Token: 0x04000C52 RID: 3154
		private static readonly IntPtr NativeFieldInfoPtr__error;

		// Token: 0x04000C53 RID: 3155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000C54 RID: 3156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C55 RID: 3157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

		// Token: 0x04000C56 RID: 3158
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_get_String_0;
	}
}
