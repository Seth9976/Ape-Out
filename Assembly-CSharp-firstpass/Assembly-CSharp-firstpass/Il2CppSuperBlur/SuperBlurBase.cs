using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppSuperBlur
{
	// Token: 0x02000005 RID: 5
	public class SuperBlurBase : MonoBehaviour
	{
		// Token: 0x06000018 RID: 24 RVA: 0x0000E388 File Offset: 0x0000C588
		// Note: this type is marked as 'beforefieldinit'.
		static SuperBlurBase()
		{
			Il2CppClassPointerStore<SuperBlurBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SuperBlur", "SuperBlurBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SuperBlurBase>.NativeClassPtr);
			SuperBlurBase.NativeFieldInfoPtr_renderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuperBlurBase>.NativeClassPtr, "renderMode");
			SuperBlurBase.NativeFieldInfoPtr_kernelSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuperBlurBase>.NativeClassPtr, "kernelSize");
			SuperBlurBase.NativeFieldInfoPtr_interpolation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuperBlurBase>.NativeClassPtr, "interpolation");
			SuperBlurBase.NativeFieldInfoPtr_downsample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuperBlurBase>.NativeClassPtr, "downsample");
			SuperBlurBase.NativeFieldInfoPtr_iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuperBlurBase>.NativeClassPtr, "iterations");
			SuperBlurBase.NativeFieldInfoPtr_gammaCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuperBlurBase>.NativeClassPtr, "gammaCorrection");
			SuperBlurBase.NativeFieldInfoPtr_blurMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuperBlurBase>.NativeClassPtr, "blurMaterial");
			SuperBlurBase.NativeFieldInfoPtr_UIMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuperBlurBase>.NativeClassPtr, "UIMaterial");
			SuperBlurBase.NativeMethodInfoPtr_Blur_Protected_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuperBlurBase>.NativeClassPtr, 100663311);
			SuperBlurBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SuperBlurBase>.NativeClassPtr, 100663312);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000E480 File Offset: 0x0000C680
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 259, RefRangeEnd = 265, XrefRangeStart = 222, XrefRangeEnd = 259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blur(RenderTexture source, RenderTexture destination)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SuperBlurBase.NativeMethodInfoPtr_Blur_Protected_Void_RenderTexture_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000E4D4 File Offset: 0x0000C6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265, XrefRangeEnd = 268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SuperBlurBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SuperBlurBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SuperBlurBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000208A File Offset: 0x0000028A
		public SuperBlurBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x0000E510 File Offset: 0x0000C710
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002093 File Offset: 0x00000293
		public unsafe RenderMode renderMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_renderMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_renderMode)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000E538 File Offset: 0x0000C738
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000020AE File Offset: 0x000002AE
		public unsafe BlurKernelSize kernelSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_kernelSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_kernelSize)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000E560 File Offset: 0x0000C760
		// (set) Token: 0x06000021 RID: 33 RVA: 0x000020C9 File Offset: 0x000002C9
		public unsafe float interpolation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_interpolation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_interpolation)) = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000E588 File Offset: 0x0000C788
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000020E4 File Offset: 0x000002E4
		public unsafe int downsample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_downsample);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_downsample)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000020FF File Offset: 0x000002FF
		public unsafe int iterations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_iterations);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_iterations)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000E5D8 File Offset: 0x0000C7D8
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0000211A File Offset: 0x0000031A
		public unsafe bool gammaCorrection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_gammaCorrection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_gammaCorrection)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000E600 File Offset: 0x0000C800
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00002135 File Offset: 0x00000335
		public unsafe Material blurMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_blurMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_blurMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000E630 File Offset: 0x0000C830
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002154 File Offset: 0x00000354
		public unsafe Material UIMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_UIMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SuperBlurBase.NativeFieldInfoPtr_UIMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_renderMode;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_kernelSize;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_interpolation;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_downsample;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_iterations;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_gammaCorrection;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_blurMaterial;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_UIMaterial;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Blur_Protected_Void_RenderTexture_RenderTexture_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000218 RID: 536
		public static class Uniforms : global::Il2CppSystem.Object
		{
			// Token: 0x06001E6D RID: 7789 RVA: 0x00087C04 File Offset: 0x00085E04
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<SuperBlurBase.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SuperBlurBase>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SuperBlurBase.Uniforms>.NativeClassPtr);
				SuperBlurBase.Uniforms.NativeFieldInfoPtr__Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuperBlurBase.Uniforms>.NativeClassPtr, "_Radius");
				SuperBlurBase.Uniforms.NativeFieldInfoPtr__BackgroundTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SuperBlurBase.Uniforms>.NativeClassPtr, "_BackgroundTexture");
			}

			// Token: 0x06001E6E RID: 7790 RVA: 0x0000B0C8 File Offset: 0x000092C8
			public Uniforms(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000622 RID: 1570
			// (get) Token: 0x06001E6F RID: 7791 RVA: 0x00087C58 File Offset: 0x00085E58
			// (set) Token: 0x06001E70 RID: 7792 RVA: 0x0000B0D1 File Offset: 0x000092D1
			public unsafe static int _Radius
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(SuperBlurBase.Uniforms.NativeFieldInfoPtr__Radius, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SuperBlurBase.Uniforms.NativeFieldInfoPtr__Radius, (void*)(&value));
				}
			}

			// Token: 0x17000623 RID: 1571
			// (get) Token: 0x06001E71 RID: 7793 RVA: 0x00087C74 File Offset: 0x00085E74
			// (set) Token: 0x06001E72 RID: 7794 RVA: 0x0000B0DF File Offset: 0x000092DF
			public unsafe static int _BackgroundTexture
			{
				get
				{
					int num;
					IL2CPP.il2cpp_field_static_get_value(SuperBlurBase.Uniforms.NativeFieldInfoPtr__BackgroundTexture, (void*)(&num));
					return num;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SuperBlurBase.Uniforms.NativeFieldInfoPtr__BackgroundTexture, (void*)(&value));
				}
			}

			// Token: 0x04001F4E RID: 8014
			private static readonly IntPtr NativeFieldInfoPtr__Radius;

			// Token: 0x04001F4F RID: 8015
			private static readonly IntPtr NativeFieldInfoPtr__BackgroundTexture;
		}
	}
}
