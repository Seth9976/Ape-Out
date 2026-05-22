using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000144 RID: 324
	public sealed class IPPacketInformation : ValueType
	{
		// Token: 0x06001491 RID: 5265 RVA: 0x0005D8C0 File Offset: 0x0005BAC0
		// Note: this type is marked as 'beforefieldinit'.
		static IPPacketInformation()
		{
			Il2CppClassPointerStore<IPPacketInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "IPPacketInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IPPacketInformation>.NativeClassPtr);
			IPPacketInformation.NativeFieldInfoPtr_address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPPacketInformation>.NativeClassPtr, "address");
			IPPacketInformation.NativeFieldInfoPtr_networkInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IPPacketInformation>.NativeClassPtr, "networkInterface");
			IPPacketInformation.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPPacketInformation>.NativeClassPtr, 100666223);
			IPPacketInformation.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPPacketInformation>.NativeClassPtr, 100666224);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0005D940 File Offset: 0x0005BB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386578, XrefRangeEnd = 386580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object comparand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPPacketInformation.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0005D994 File Offset: 0x0005BB94
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IPPacketInformation.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0000A683 File Offset: 0x00008883
		public IPPacketInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0000A68C File Offset: 0x0000888C
		public IPPacketInformation()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IPPacketInformation>.NativeClassPtr))
		{
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x0005D9D8 File Offset: 0x0005BBD8
		// (set) Token: 0x06001497 RID: 5271 RVA: 0x0000A69E File Offset: 0x0000889E
		public unsafe IPAddress address
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPPacketInformation.NativeFieldInfoPtr_address);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPPacketInformation.NativeFieldInfoPtr_address), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x0005DA08 File Offset: 0x0005BC08
		// (set) Token: 0x06001499 RID: 5273 RVA: 0x0000A6BD File Offset: 0x000088BD
		public unsafe int networkInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPPacketInformation.NativeFieldInfoPtr_networkInterface);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IPPacketInformation.NativeFieldInfoPtr_networkInterface)) = value;
			}
		}

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeFieldInfoPtr_address;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeFieldInfoPtr_networkInterface;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
