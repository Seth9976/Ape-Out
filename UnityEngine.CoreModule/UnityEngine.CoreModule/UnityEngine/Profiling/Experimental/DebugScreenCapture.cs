using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Profiling.Experimental
{
	// Token: 0x0200010E RID: 270
	public sealed class DebugScreenCapture : ValueType
	{
		// Token: 0x060016F5 RID: 5877 RVA: 0x00059270 File Offset: 0x00057470
		// Note: this type is marked as 'beforefieldinit'.
		static DebugScreenCapture()
		{
			Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling.Experimental", "DebugScreenCapture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr);
			DebugScreenCapture.NativeFieldInfoPtr__rawImageDataReference_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<rawImageDataReference>k__BackingField");
			DebugScreenCapture.NativeFieldInfoPtr__imageFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<imageFormat>k__BackingField");
			DebugScreenCapture.NativeFieldInfoPtr__width_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<width>k__BackingField");
			DebugScreenCapture.NativeFieldInfoPtr__height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<height>k__BackingField");
			DebugScreenCapture.NativeMethodInfoPtr_set_rawImageDataReference_Public_set_Void_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100665339);
			DebugScreenCapture.NativeMethodInfoPtr_set_imageFormat_Public_set_Void_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100665340);
			DebugScreenCapture.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100665341);
			DebugScreenCapture.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100665342);
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x0000C4F5 File Offset: 0x0000A6F5
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x00059340 File Offset: 0x00057540
		public unsafe Unity.Collections.NativeArray<byte> rawImageDataReference
		{
			get
			{
				return this._rawImageDataReference_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_rawImageDataReference_Public_set_Void_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x0000C4FD File Offset: 0x0000A6FD
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x0005938C File Offset: 0x0005758C
		public unsafe TextureFormat imageFormat
		{
			get
			{
				return this._imageFormat_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_imageFormat_Public_set_Void_TextureFormat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x0000C505 File Offset: 0x0000A705
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x000593D0 File Offset: 0x000575D0
		public unsafe int width
		{
			get
			{
				return this._width_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x0000C50D File Offset: 0x0000A70D
		// (set) Token: 0x060016F9 RID: 5881 RVA: 0x00059414 File Offset: 0x00057614
		public unsafe int height
		{
			get
			{
				return this._height_k__BackingField;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x0000C45B File Offset: 0x0000A65B
		public DebugScreenCapture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x0000C464 File Offset: 0x0000A664
		public DebugScreenCapture()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr))
		{
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x00059458 File Offset: 0x00057658
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x0000C476 File Offset: 0x0000A676
		public Unity.Collections.NativeArray<byte> _rawImageDataReference_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__rawImageDataReference_k__BackingField);
				return new Unity.Collections.NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<byte>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__rawImageDataReference_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<byte>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x00059488 File Offset: 0x00057688
		// (set) Token: 0x060016FF RID: 5887 RVA: 0x0000C4A4 File Offset: 0x0000A6A4
		public unsafe TextureFormat _imageFormat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__imageFormat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__imageFormat_k__BackingField)) = value;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x000594B0 File Offset: 0x000576B0
		// (set) Token: 0x06001701 RID: 5889 RVA: 0x0000C4BF File Offset: 0x0000A6BF
		public unsafe int _width_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__width_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__width_k__BackingField)) = value;
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x000594D8 File Offset: 0x000576D8
		// (set) Token: 0x06001703 RID: 5891 RVA: 0x0000C4DA File Offset: 0x0000A6DA
		public unsafe int _height_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__height_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__height_k__BackingField)) = value;
			}
		}

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeFieldInfoPtr__rawImageDataReference_k__BackingField;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeFieldInfoPtr__imageFormat_k__BackingField;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeFieldInfoPtr__width_k__BackingField;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeFieldInfoPtr__height_k__BackingField;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr_set_rawImageDataReference_Public_set_Void_NativeArray_1_Byte_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr_set_imageFormat_Public_set_Void_TextureFormat_0;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0;
	}
}
