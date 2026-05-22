using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Resources
{
	// Token: 0x02000182 RID: 386
	[Serializable]
	public class MissingSatelliteAssemblyException : SystemException
	{
		// Token: 0x06001ACE RID: 6862 RVA: 0x0009E618 File Offset: 0x0009C818
		// Note: this type is marked as 'beforefieldinit'.
		static MissingSatelliteAssemblyException()
		{
			Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "MissingSatelliteAssemblyException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr);
			MissingSatelliteAssemblyException.NativeFieldInfoPtr__cultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr, "_cultureName");
			MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr, 100667893);
			MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr, 100667894);
			MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr, 100667895);
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0009E698 File Offset: 0x0009C898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185191, XrefRangeEnd = 185194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingSatelliteAssemblyException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x0009E6D4 File Offset: 0x0009C8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185195, RefRangeEnd = 185196, XrefRangeStart = 185194, XrefRangeEnd = 185195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingSatelliteAssemblyException(string message, string cultureName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cultureName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x0009E734 File Offset: 0x0009C934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingSatelliteAssemblyException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingSatelliteAssemblyException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingSatelliteAssemblyException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00008FD0 File Offset: 0x000071D0
		public MissingSatelliteAssemblyException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x0009E798 File Offset: 0x0009C998
		// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x00008FD9 File Offset: 0x000071D9
		public unsafe string _cultureName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingSatelliteAssemblyException.NativeFieldInfoPtr__cultureName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingSatelliteAssemblyException.NativeFieldInfoPtr__cultureName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeFieldInfoPtr__cultureName;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
