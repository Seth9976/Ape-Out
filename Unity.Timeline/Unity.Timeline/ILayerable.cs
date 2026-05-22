using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200002F RID: 47
	public class ILayerable : Il2CppObjectBase
	{
		// Token: 0x06000404 RID: 1028 RVA: 0x0000345E File Offset: 0x0000165E
		// Note: this type is marked as 'beforefieldinit'.
		static ILayerable()
		{
			Il2CppClassPointerStore<ILayerable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "ILayerable");
			ILayerable.NativeMethodInfoPtr_CreateLayerMixer_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILayerable>.NativeClassPtr, 100663982);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00014474 File Offset: 0x00012674
		[CallerCount(0)]
		public unsafe virtual Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref graph;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILayerable.NativeMethodInfoPtr_CreateLayerMixer_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000348D File Offset: 0x0000168D
		public ILayerable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_CreateLayerMixer_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_Int32_0;
	}
}
