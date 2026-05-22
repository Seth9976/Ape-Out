using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSanford.Multimedia.Midi
{
	// Token: 0x020001B0 RID: 432
	public class IMessageBuilder : Il2CppObjectBase
	{
		// Token: 0x06001489 RID: 5257 RVA: 0x00008625 File Offset: 0x00006825
		// Note: this type is marked as 'beforefieldinit'.
		static IMessageBuilder()
		{
			Il2CppClassPointerStore<IMessageBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Sanford.Multimedia.Midi", "IMessageBuilder");
			IMessageBuilder.NativeMethodInfoPtr_Build_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMessageBuilder>.NativeClassPtr, 100666214);
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0005ECC8 File Offset: 0x0005CEC8
		[CallerCount(0)]
		public unsafe virtual void Build()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IMessageBuilder.NativeMethodInfoPtr_Build_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00008654 File Offset: 0x00006854
		public IMessageBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Abstract_Virtual_New_Void_0;
	}
}
