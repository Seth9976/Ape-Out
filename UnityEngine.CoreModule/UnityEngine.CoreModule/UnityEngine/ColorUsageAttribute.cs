using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x020000B9 RID: 185
	public sealed class ColorUsageAttribute : PropertyAttribute
	{
		// Token: 0x06001190 RID: 4496 RVA: 0x00048554 File Offset: 0x00046754
		// Note: this type is marked as 'beforefieldinit'.
		static ColorUsageAttribute()
		{
			Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ColorUsageAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr);
			ColorUsageAttribute.NativeFieldInfoPtr_showAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "showAlpha");
			ColorUsageAttribute.NativeFieldInfoPtr_hdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "hdr");
			ColorUsageAttribute.NativeFieldInfoPtr_minBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "minBrightness");
			ColorUsageAttribute.NativeFieldInfoPtr_maxBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "maxBrightness");
			ColorUsageAttribute.NativeFieldInfoPtr_minExposureValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "minExposureValue");
			ColorUsageAttribute.NativeFieldInfoPtr_maxExposureValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, "maxExposureValue");
			ColorUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, 100664752);
			ColorUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, 100664753);
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00048624 File Offset: 0x00046824
		[CallerCount(0)]
		public unsafe ColorUsageAttribute(bool showAlpha)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref showAlpha;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0004866C File Offset: 0x0004686C
		[CallerCount(0)]
		public unsafe ColorUsageAttribute(bool showAlpha, bool hdr)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref showAlpha;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hdr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0000A49A File Offset: 0x0000869A
		public ColorUsageAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x000486C4 File Offset: 0x000468C4
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x0000A4A3 File Offset: 0x000086A3
		public unsafe bool showAlpha
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_showAlpha);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_showAlpha)) = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x000486EC File Offset: 0x000468EC
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x0000A4BE File Offset: 0x000086BE
		public unsafe bool hdr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_hdr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_hdr)) = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x00048714 File Offset: 0x00046914
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x0000A4D9 File Offset: 0x000086D9
		public unsafe float minBrightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minBrightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minBrightness)) = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x0004873C File Offset: 0x0004693C
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x0000A4F4 File Offset: 0x000086F4
		public unsafe float maxBrightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxBrightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxBrightness)) = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x00048764 File Offset: 0x00046964
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x0000A50F File Offset: 0x0000870F
		public unsafe float minExposureValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minExposureValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minExposureValue)) = value;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x0004878C File Offset: 0x0004698C
		// (set) Token: 0x0600119F RID: 4511 RVA: 0x0000A52A File Offset: 0x0000872A
		public unsafe float maxExposureValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxExposureValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxExposureValue)) = value;
			}
		}

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeFieldInfoPtr_showAlpha;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeFieldInfoPtr_hdr;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeFieldInfoPtr_minBrightness;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeFieldInfoPtr_maxBrightness;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeFieldInfoPtr_minExposureValue;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeFieldInfoPtr_maxExposureValue;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;
	}
}
