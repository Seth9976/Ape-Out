using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000053 RID: 83
	[StructLayout(2)]
	public struct PostProcessEventComparer
	{
		// Token: 0x0600036E RID: 878 RVA: 0x00010A00 File Offset: 0x0000EC00
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessEventComparer()
		{
			Il2CppClassPointerStore<PostProcessEventComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Postprocessing.Runtime.dll", "UnityEngine.Rendering.PostProcessing", "PostProcessEventComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessEventComparer>.NativeClassPtr);
			PostProcessEventComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PostProcessEvent_PostProcessEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEventComparer>.NativeClassPtr, 100663584);
			PostProcessEventComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_PostProcessEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessEventComparer>.NativeClassPtr, 100663585);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00010A58 File Offset: 0x0000EC58
		[CallerCount(0)]
		public unsafe bool Equals(PostProcessEvent x, PostProcessEvent y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEventComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PostProcessEvent_PostProcessEvent_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00010AA4 File Offset: 0x0000ECA4
		[CallerCount(0)]
		public unsafe int GetHashCode(PostProcessEvent obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessEventComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_PostProcessEvent_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00003E94 File Offset: 0x00002094
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PostProcessEventComparer>.NativeClassPtr, ref this));
		}

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PostProcessEvent_PostProcessEvent_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_PostProcessEvent_0;
	}
}
