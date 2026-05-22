using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x020001A3 RID: 419
	[StructLayout(2)]
	public struct MaterialEffectPlayable
	{
		// Token: 0x06001F18 RID: 7960 RVA: 0x00072890 File Offset: 0x00070A90
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialEffectPlayable()
		{
			Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "MaterialEffectPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr);
			MaterialEffectPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, "m_Handle");
			MaterialEffectPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, 100666154);
			MaterialEffectPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, 100666155);
			MaterialEffectPlayable.GetMaterialInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.GetMaterialInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::GetMaterialInternal");
			MaterialEffectPlayable.SetMaterialInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.SetMaterialInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::SetMaterialInternal");
			MaterialEffectPlayable.GetPassInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.GetPassInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::GetPassInternal");
			MaterialEffectPlayable.SetPassInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.SetPassInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::SetPassInternal");
			MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::InternalCreateMaterialEffectPlayable");
			MaterialEffectPlayable.ValidateTypeDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.ValidateTypeDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::ValidateType");
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00072958 File Offset: 0x00070B58
		[CallerCount(0)]
		public unsafe UnityEngine.Playables.PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEffectPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00072988 File Offset: 0x00070B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504703, XrefRangeEnd = 504710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(MaterialEffectPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEffectPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x00010205 File Offset: 0x0000E405
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x000729C8 File Offset: 0x00070BC8
		public static MaterialEffectPlayable Create(UnityEngine.Playables.PlayableGraph graph, Material material, [Optional] int pass)
		{
			UnityEngine.Playables.PlayableHandle playableHandle = MaterialEffectPlayable.CreateHandle(graph, material, pass);
			return new MaterialEffectPlayable(playableHandle);
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x000729EC File Offset: 0x00070BEC
		public static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, Material material, int pass)
		{
			UnityEngine.Playables.PlayableHandle @null = UnityEngine.Playables.PlayableHandle.Null;
			bool flag = !MaterialEffectPlayable.InternalCreateMaterialEffectPlayable(ref graph, material, pass, ref @null);
			UnityEngine.Playables.PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = UnityEngine.Playables.PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00072A20 File Offset: 0x00070C20
		public static implicit operator UnityEngine.Playables.Playable(MaterialEffectPlayable playable)
		{
			return new UnityEngine.Playables.Playable(playable.GetHandle());
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00072A40 File Offset: 0x00070C40
		public static explicit operator MaterialEffectPlayable(UnityEngine.Playables.Playable playable)
		{
			return new MaterialEffectPlayable(playable.GetHandle());
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00072A60 File Offset: 0x00070C60
		public Material GetMaterial()
		{
			return MaterialEffectPlayable.GetMaterialInternal(ref this.m_Handle);
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00010217 File Offset: 0x0000E417
		public void SetMaterial(Material value)
		{
			MaterialEffectPlayable.SetMaterialInternal(ref this.m_Handle, value);
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00072A80 File Offset: 0x00070C80
		public int GetPass()
		{
			return MaterialEffectPlayable.GetPassInternal(ref this.m_Handle);
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00010227 File Offset: 0x0000E427
		public void SetPass(int value)
		{
			MaterialEffectPlayable.SetPassInternal(ref this.m_Handle, value);
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00072AA0 File Offset: 0x00070CA0
		public static Material GetMaterialInternal(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			IntPtr intPtr = MaterialEffectPlayable.GetMaterialInternalDelegateField(ref hdl);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00010237 File Offset: 0x0000E437
		public static void SetMaterialInternal(ref UnityEngine.Playables.PlayableHandle hdl, Material material)
		{
			MaterialEffectPlayable.SetMaterialInternalDelegateField(ref hdl, IL2CPP.Il2CppObjectBaseToPtr(material));
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x0001024A File Offset: 0x0000E44A
		public static int GetPassInternal(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			return MaterialEffectPlayable.GetPassInternalDelegateField(ref hdl);
		}

		// Token: 0x06001F27 RID: 7975 RVA: 0x00010257 File Offset: 0x0000E457
		public static void SetPassInternal(ref UnityEngine.Playables.PlayableHandle hdl, int pass)
		{
			MaterialEffectPlayable.SetPassInternalDelegateField(ref hdl, pass);
		}

		// Token: 0x06001F28 RID: 7976 RVA: 0x00010265 File Offset: 0x0000E465
		public static bool InternalCreateMaterialEffectPlayable(ref UnityEngine.Playables.PlayableGraph graph, Material material, int pass, ref UnityEngine.Playables.PlayableHandle handle)
		{
			return MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(material), pass, ref handle);
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x0001027A File Offset: 0x0000E47A
		public static bool ValidateType(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			return MaterialEffectPlayable.ValidateTypeDelegateField(ref hdl);
		}

		// Token: 0x04001889 RID: 6281
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x0400188A RID: 6282
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x0400188B RID: 6283
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0;

		// Token: 0x0400188C RID: 6284
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableHandle m_Handle;

		// Token: 0x0400188D RID: 6285
		private static readonly MaterialEffectPlayable.GetMaterialInternalDelegate GetMaterialInternalDelegateField;

		// Token: 0x0400188E RID: 6286
		private static readonly MaterialEffectPlayable.SetMaterialInternalDelegate SetMaterialInternalDelegateField;

		// Token: 0x0400188F RID: 6287
		private static readonly MaterialEffectPlayable.GetPassInternalDelegate GetPassInternalDelegateField;

		// Token: 0x04001890 RID: 6288
		private static readonly MaterialEffectPlayable.SetPassInternalDelegate SetPassInternalDelegateField;

		// Token: 0x04001891 RID: 6289
		private static readonly MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegate InternalCreateMaterialEffectPlayableDelegateField;

		// Token: 0x04001892 RID: 6290
		private static readonly MaterialEffectPlayable.ValidateTypeDelegate ValidateTypeDelegateField;

		// Token: 0x02000A4C RID: 2636
		// (Invoke) Token: 0x06003318 RID: 13080
		private delegate IntPtr GetMaterialInternalDelegate(IntPtr hdl);

		// Token: 0x02000A4D RID: 2637
		// (Invoke) Token: 0x0600331A RID: 13082
		private delegate void SetMaterialInternalDelegate(IntPtr hdl, IntPtr material);

		// Token: 0x02000A4E RID: 2638
		// (Invoke) Token: 0x0600331C RID: 13084
		private delegate int GetPassInternalDelegate(IntPtr hdl);

		// Token: 0x02000A4F RID: 2639
		// (Invoke) Token: 0x0600331E RID: 13086
		private delegate void SetPassInternalDelegate(IntPtr hdl, int pass);

		// Token: 0x02000A50 RID: 2640
		// (Invoke) Token: 0x06003320 RID: 13088
		private delegate bool InternalCreateMaterialEffectPlayableDelegate(IntPtr graph, IntPtr material, int pass, IntPtr handle);

		// Token: 0x02000A51 RID: 2641
		// (Invoke) Token: 0x06003322 RID: 13090
		private delegate bool ValidateTypeDelegate(IntPtr hdl);
	}
}
