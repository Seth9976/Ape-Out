using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppRewired.Utils.Attributes
{
	// Token: 0x02000009 RID: 9
	public class SerializationTypeAttribute : Attribute
	{
		// Token: 0x06000034 RID: 52 RVA: 0x0002CF5C File Offset: 0x0002B15C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationTypeAttribute()
		{
			Il2CppClassPointerStore<SerializationTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Core.dll", "Rewired.Utils.Attributes", "SerializationTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationTypeAttribute>.NativeClassPtr);
			SerializationTypeAttribute.NativeFieldInfoPtr__serializationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationTypeAttribute>.NativeClassPtr, "_serializationType");
			SerializationTypeAttribute.NativeMethodInfoPtr_get_serializationType_Public_get_SerializationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationTypeAttribute>.NativeClassPtr, 100663310);
			SerializationTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_SerializationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationTypeAttribute>.NativeClassPtr, 100663311);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0002CFC8 File Offset: 0x0002B1C8
		public unsafe SerializationTypeAttribute.SerializationType serializationType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 896, RefRangeEnd = 897, XrefRangeStart = 896, XrefRangeEnd = 897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationTypeAttribute.NativeMethodInfoPtr_get_serializationType_Public_get_SerializationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0002D004 File Offset: 0x0002B204
		[CallerCount(0)]
		public unsafe SerializationTypeAttribute(SerializationTypeAttribute.SerializationType serializationType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationTypeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serializationType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_SerializationType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002224 File Offset: 0x00000424
		public SerializationTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0002D04C File Offset: 0x0002B24C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000222D File Offset: 0x0000042D
		public unsafe SerializationTypeAttribute.SerializationType _serializationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationTypeAttribute.NativeFieldInfoPtr__serializationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializationTypeAttribute.NativeFieldInfoPtr__serializationType)) = value;
			}
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr__serializationType;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_serializationType_Public_get_SerializationType_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationType_0;

		// Token: 0x0200021D RID: 541
		[OriginalName("Rewired_Core.dll", "", "SerializationType")]
		public enum SerializationType
		{
			// Token: 0x04002EEA RID: 12010
			Default,
			// Token: 0x04002EEB RID: 12011
			Object
		}
	}
}
