using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x0200033F RID: 831
	public sealed class OptionalFieldAttribute : Attribute
	{
		// Token: 0x06003685 RID: 13957 RVA: 0x0010B6C8 File Offset: 0x001098C8
		// Note: this type is marked as 'beforefieldinit'.
		static OptionalFieldAttribute()
		{
			Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "OptionalFieldAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr);
			OptionalFieldAttribute.NativeFieldInfoPtr_versionAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr, "versionAdded");
			OptionalFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr, 100671767);
			OptionalFieldAttribute.NativeMethodInfoPtr_set_VersionAdded_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr, 100671768);
		}

		// Token: 0x06003686 RID: 13958 RVA: 0x0010B734 File Offset: 0x00109934
		[CallerCount(0)]
		public unsafe OptionalFieldAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D1F RID: 3359
		// (set) Token: 0x06003687 RID: 13959 RVA: 0x0010B770 File Offset: 0x00109970
		public unsafe int VersionAdded
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionalFieldAttribute.NativeMethodInfoPtr_set_VersionAdded_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x0001355F File Offset: 0x0001175F
		public OptionalFieldAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06003689 RID: 13961 RVA: 0x0010B7B0 File Offset: 0x001099B0
		// (set) Token: 0x0600368A RID: 13962 RVA: 0x00013568 File Offset: 0x00011768
		public unsafe int versionAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionalFieldAttribute.NativeFieldInfoPtr_versionAdded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionalFieldAttribute.NativeFieldInfoPtr_versionAdded)) = value;
			}
		}

		// Token: 0x04002DFE RID: 11774
		private static readonly IntPtr NativeFieldInfoPtr_versionAdded;

		// Token: 0x04002DFF RID: 11775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E00 RID: 11776
		private static readonly IntPtr NativeMethodInfoPtr_set_VersionAdded_Public_set_Void_Int32_0;
	}
}
