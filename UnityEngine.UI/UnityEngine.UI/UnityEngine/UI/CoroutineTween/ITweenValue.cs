using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000048 RID: 72
	public class ITweenValue : Il2CppObjectBase
	{
		// Token: 0x06000872 RID: 2162 RVA: 0x00027E10 File Offset: 0x00026010
		// Note: this type is marked as 'beforefieldinit'.
		static ITweenValue()
		{
			Il2CppClassPointerStore<ITweenValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI.CoroutineTween", "ITweenValue");
			ITweenValue.NativeMethodInfoPtr_TweenValue_Public_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100664665);
			ITweenValue.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100664666);
			ITweenValue.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100664667);
			ITweenValue.NativeMethodInfoPtr_ValidTarget_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITweenValue>.NativeClassPtr, 100664668);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00027E88 File Offset: 0x00026088
		[CallerCount(0)]
		public unsafe virtual void TweenValue(float floatPercentage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref floatPercentage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITweenValue.NativeMethodInfoPtr_TweenValue_Public_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00027ED4 File Offset: 0x000260D4
		public unsafe virtual bool ignoreTimeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITweenValue.NativeMethodInfoPtr_get_ignoreTimeScale_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00027F1C File Offset: 0x0002611C
		public unsafe virtual float duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITweenValue.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00027F64 File Offset: 0x00026164
		[CallerCount(0)]
		public unsafe virtual bool ValidTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITweenValue.NativeMethodInfoPtr_ValidTarget_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00004E90 File Offset: 0x00003090
		public ITweenValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_TweenValue_Public_Abstract_Virtual_New_Void_Single_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreTimeScale_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_ValidTarget_Public_Abstract_Virtual_New_Boolean_0;
	}
}
