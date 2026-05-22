using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000075 RID: 117
	public class ComponentConverter : ReferenceConverter
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x000052E3 File Offset: 0x000034E3
		// Note: this type is marked as 'beforefieldinit'.
		static ComponentConverter()
		{
			Il2CppClassPointerStore<ComponentConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ComponentConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComponentConverter>.NativeClassPtr);
			ComponentConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComponentConverter>.NativeClassPtr, 100664477);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x0002F3FC File Offset: 0x0002D5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 372781, XrefRangeEnd = 372784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ComponentConverter(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComponentConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ComponentConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0000531C File Offset: 0x0000351C
		public ComponentConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
