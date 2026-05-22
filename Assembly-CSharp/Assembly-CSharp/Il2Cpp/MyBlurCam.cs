using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000135 RID: 309
	public class MyBlurCam : MonoBehaviour
	{
		// Token: 0x0600264E RID: 9806 RVA: 0x0009EA80 File Offset: 0x0009CC80
		// Note: this type is marked as 'beforefieldinit'.
		static MyBlurCam()
		{
			Il2CppClassPointerStore<MyBlurCam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MyBlurCam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyBlurCam>.NativeClassPtr);
			MyBlurCam.NativeFieldInfoPtr_FrontColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyBlurCam>.NativeClassPtr, "FrontColor");
			MyBlurCam.NativeFieldInfoPtr_BackColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyBlurCam>.NativeClassPtr, "BackColor");
			MyBlurCam.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyBlurCam>.NativeClassPtr, "material");
			MyBlurCam.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyBlurCam>.NativeClassPtr, 100666349);
			MyBlurCam.NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyBlurCam>.NativeClassPtr, 100666350);
			MyBlurCam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyBlurCam>.NativeClassPtr, 100666351);
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x0009EB28 File Offset: 0x0009CD28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74362, XrefRangeEnd = 74374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MyBlurCam.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x0009EB5C File Offset: 0x0009CD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74374, XrefRangeEnd = 74378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MyBlurCam.NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x0009EBB0 File Offset: 0x0009CDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74378, XrefRangeEnd = 74381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MyBlurCam()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyBlurCam>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MyBlurCam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x0001AC26 File Offset: 0x00018E26
		public MyBlurCam(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06002653 RID: 9811 RVA: 0x0009EBEC File Offset: 0x0009CDEC
		// (set) Token: 0x06002654 RID: 9812 RVA: 0x0001AC2F File Offset: 0x00018E2F
		public unsafe Color FrontColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyBlurCam.NativeFieldInfoPtr_FrontColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyBlurCam.NativeFieldInfoPtr_FrontColor)) = value;
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06002655 RID: 9813 RVA: 0x0009EC14 File Offset: 0x0009CE14
		// (set) Token: 0x06002656 RID: 9814 RVA: 0x0001AC4A File Offset: 0x00018E4A
		public unsafe Color BackColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyBlurCam.NativeFieldInfoPtr_BackColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyBlurCam.NativeFieldInfoPtr_BackColor)) = value;
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06002657 RID: 9815 RVA: 0x0009EC3C File Offset: 0x0009CE3C
		// (set) Token: 0x06002658 RID: 9816 RVA: 0x0001AC65 File Offset: 0x00018E65
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyBlurCam.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyBlurCam.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeFieldInfoPtr_FrontColor;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeFieldInfoPtr_BackColor;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
