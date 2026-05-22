using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000B8 RID: 184
	public sealed class TextAreaAttribute : PropertyAttribute
	{
		// Token: 0x06001189 RID: 4489 RVA: 0x00048440 File Offset: 0x00046640
		// Note: this type is marked as 'beforefieldinit'.
		static TextAreaAttribute()
		{
			Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TextAreaAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr);
			TextAreaAttribute.NativeFieldInfoPtr_minLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, "minLines");
			TextAreaAttribute.NativeFieldInfoPtr_maxLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, "maxLines");
			TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, 100664751);
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x000484AC File Offset: 0x000466AC
		[CallerCount(0)]
		public unsafe TextAreaAttribute(int minLines, int maxLines)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minLines;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLines;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x0000A45B File Offset: 0x0000865B
		public TextAreaAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x00048504 File Offset: 0x00046704
		// (set) Token: 0x0600118D RID: 4493 RVA: 0x0000A464 File Offset: 0x00008664
		public unsafe int minLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_minLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_minLines)) = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x0004852C File Offset: 0x0004672C
		// (set) Token: 0x0600118F RID: 4495 RVA: 0x0000A47F File Offset: 0x0000867F
		public unsafe int maxLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_maxLines);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_maxLines)) = value;
			}
		}

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeFieldInfoPtr_minLines;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeFieldInfoPtr_maxLines;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
	}
}
