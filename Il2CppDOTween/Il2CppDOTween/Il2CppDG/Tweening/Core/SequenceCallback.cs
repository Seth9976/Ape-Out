using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppDG.Tweening.Core
{
	// Token: 0x02000050 RID: 80
	public class SequenceCallback : ABSSequentiable
	{
		// Token: 0x060004E8 RID: 1256 RVA: 0x00003A08 File Offset: 0x00001C08
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceCallback()
		{
			Il2CppClassPointerStore<SequenceCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "SequenceCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceCallback>.NativeClassPtr);
			SequenceCallback.NativeMethodInfoPtr__ctor_Public_Void_Single_TweenCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCallback>.NativeClassPtr, 100664253);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0001C800 File Offset: 0x0001AA00
		[CallerCount(0)]
		public unsafe SequenceCallback(float sequencedPosition, TweenCallback callback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sequencedPosition;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCallback.NativeMethodInfoPtr__ctor_Public_Void_Single_TweenCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00003A41 File Offset: 0x00001C41
		public SequenceCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_TweenCallback_0;
	}
}
