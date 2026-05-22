using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000008 RID: 8
	[Serializable]
	public class GUIContent : Object
	{
		// Token: 0x06000173 RID: 371 RVA: 0x00009618 File Offset: 0x00007818
		// Note: this type is marked as 'beforefieldinit'.
		static GUIContent()
		{
			Il2CppClassPointerStore<GUIContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIContent>.NativeClassPtr);
			GUIContent.NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "m_Text");
			GUIContent.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "m_Image");
			GUIContent.NativeFieldInfoPtr_m_Tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "m_Tooltip");
			GUIContent.NativeFieldInfoPtr_s_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "s_Text");
			GUIContent.NativeFieldInfoPtr_s_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "s_Image");
			GUIContent.NativeFieldInfoPtr_s_TextImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "s_TextImage");
			GUIContent.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, "none");
			GUIContent.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663420);
			GUIContent.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663421);
			GUIContent.NativeMethodInfoPtr_set_image_Public_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663422);
			GUIContent.NativeMethodInfoPtr_get_tooltip_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663423);
			GUIContent.NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663424);
			GUIContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663425);
			GUIContent.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663426);
			GUIContent.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663427);
			GUIContent.NativeMethodInfoPtr__ctor_Public_Void_String_Texture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663428);
			GUIContent.NativeMethodInfoPtr__ctor_Public_Void_GUIContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663429);
			GUIContent.NativeMethodInfoPtr_Temp_Internal_Static_GUIContent_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663430);
			GUIContent.NativeMethodInfoPtr_ClearStaticCache_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIContent>.NativeClassPtr, 100663431);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000174 RID: 372 RVA: 0x000097C4 File Offset: 0x000079C4
		// (set) Token: 0x06000175 RID: 373 RVA: 0x000097FC File Offset: 0x000079FC
		public unsafe string text
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00009C30 File Offset: 0x00007E30
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00009840 File Offset: 0x00007A40
		public unsafe Texture image
		{
			get
			{
				return this.m_Image;
			}
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 18562, RefRangeEnd = 18620, XrefRangeStart = 18562, XrefRangeEnd = 18620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_set_image_Public_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00009884 File Offset: 0x00007A84
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000098BC File Offset: 0x00007ABC
		public unsafe string tooltip
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_get_tooltip_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 18620, RefRangeEnd = 18653, XrefRangeStart = 18620, XrefRangeEnd = 18653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00009900 File Offset: 0x00007B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507080, RefRangeEnd = 507081, XrefRangeStart = 507077, XrefRangeEnd = 507080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIContent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000993C File Offset: 0x00007B3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 507084, RefRangeEnd = 507087, XrefRangeStart = 507081, XrefRangeEnd = 507084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIContent(string text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIContent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00009988 File Offset: 0x00007B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507087, XrefRangeEnd = 507088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIContent(string text, string tooltip)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIContent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000099E8 File Offset: 0x00007BE8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 507091, RefRangeEnd = 507097, XrefRangeStart = 507088, XrefRangeEnd = 507091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIContent(string text, Texture image, string tooltip)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIContent>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tooltip);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr__ctor_Public_Void_String_Texture_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00009A58 File Offset: 0x00007C58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 507100, RefRangeEnd = 507102, XrefRangeStart = 507097, XrefRangeEnd = 507100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIContent(GUIContent src)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIContent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr__ctor_Public_Void_GUIContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00009AA4 File Offset: 0x00007CA4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 507110, RefRangeEnd = 507122, XrefRangeStart = 507102, XrefRangeEnd = 507110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUIContent Temp(string t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_Temp_Internal_Static_GUIContent_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr3) : null;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00009AE8 File Offset: 0x00007CE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 507134, RefRangeEnd = 507135, XrefRangeStart = 507122, XrefRangeEnd = 507134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearStaticCache()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIContent.NativeMethodInfoPtr_ClearStaticCache_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002704 File Offset: 0x00000904
		public GUIContent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00009B10 File Offset: 0x00007D10
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0000270D File Offset: 0x0000090D
		public unsafe string m_Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00009B38 File Offset: 0x00007D38
		// (set) Token: 0x06000184 RID: 388 RVA: 0x0000272C File Offset: 0x0000092C
		public unsafe Texture m_Image
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Image);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00009B68 File Offset: 0x00007D68
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0000274B File Offset: 0x0000094B
		public unsafe string m_Tooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Tooltip);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIContent.NativeFieldInfoPtr_m_Tooltip), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00009B90 File Offset: 0x00007D90
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0000276A File Offset: 0x0000096A
		public unsafe static GUIContent s_Text
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIContent.NativeFieldInfoPtr_s_Text, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIContent.NativeFieldInfoPtr_s_Text, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00009BB8 File Offset: 0x00007DB8
		// (set) Token: 0x0600018A RID: 394 RVA: 0x0000277C File Offset: 0x0000097C
		public unsafe static GUIContent s_Image
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIContent.NativeFieldInfoPtr_s_Image, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIContent.NativeFieldInfoPtr_s_Image, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00009BE0 File Offset: 0x00007DE0
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0000278E File Offset: 0x0000098E
		public unsafe static GUIContent s_TextImage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIContent.NativeFieldInfoPtr_s_TextImage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIContent.NativeFieldInfoPtr_s_TextImage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00009C08 File Offset: 0x00007E08
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000027A0 File Offset: 0x000009A0
		public unsafe static GUIContent none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIContent.NativeFieldInfoPtr_none, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIContent>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIContent.NativeFieldInfoPtr_none, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00009C48 File Offset: 0x00007E48
		public int hash
		{
			get
			{
				int num = 0;
				bool flag = !String.IsNullOrEmpty(this.m_Text);
				if (flag)
				{
					num = this.m_Text.GetHashCode() * 37;
				}
				return num;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00009C80 File Offset: 0x00007E80
		public static GUIContent Temp(string t, string tooltip)
		{
			GUIContent.s_Text.m_Text = t;
			GUIContent.s_Text.m_Tooltip = tooltip;
			return GUIContent.s_Text;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00009CB0 File Offset: 0x00007EB0
		public static GUIContent Temp(Texture i)
		{
			GUIContent.s_Image.m_Image = i;
			GUIContent.s_Image.m_Tooltip = String.Empty;
			return GUIContent.s_Image;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00009CE4 File Offset: 0x00007EE4
		public static GUIContent Temp(Texture i, string tooltip)
		{
			GUIContent.s_Image.m_Image = i;
			GUIContent.s_Image.m_Tooltip = tooltip;
			return GUIContent.s_Image;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00009D14 File Offset: 0x00007F14
		public static GUIContent Temp(string t, Texture i)
		{
			GUIContent.s_TextImage.m_Text = t;
			GUIContent.s_TextImage.m_Image = i;
			return GUIContent.s_TextImage;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000027B2 File Offset: 0x000009B2
		public static Il2CppReferenceArray<GUIContent> Temp(Il2CppStringArray texts)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000027BF File Offset: 0x000009BF
		public static Il2CppReferenceArray<GUIContent> Temp(Il2CppReferenceArray<Texture> images)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_m_Text;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeFieldInfoPtr_m_Image;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_m_Tooltip;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_s_Text;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_s_Image;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_s_TextImage;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_set_image_Public_set_Void_Texture_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_get_tooltip_Public_get_String_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_set_tooltip_Public_set_Void_String_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Texture_String_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GUIContent_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_Temp_Internal_Static_GUIContent_String_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_ClearStaticCache_Internal_Static_Void_0;
	}
}
