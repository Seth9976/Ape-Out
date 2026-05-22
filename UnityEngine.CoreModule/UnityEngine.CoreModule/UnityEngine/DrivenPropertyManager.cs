using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000249 RID: 585
	public class DrivenPropertyManager
	{
		// Token: 0x060021BB RID: 8635 RVA: 0x00011EA5 File Offset: 0x000100A5
		public static void RegisterProperty(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.RegisterPropertyPartial(driver, target, propertyPath);
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x00011EB1 File Offset: 0x000100B1
		public static void TryRegisterProperty(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.TryRegisterPropertyPartial(driver, target, propertyPath);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x00011EBD File Offset: 0x000100BD
		public static void UnregisterProperty(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.UnregisterPropertyPartial(driver, target, propertyPath);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x00011EC9 File Offset: 0x000100C9
		public static void UnregisterProperties(Object driver)
		{
			DrivenPropertyManager.UnregisterPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver));
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x00011EDB File Offset: 0x000100DB
		public static void RegisterPropertyPartial(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.RegisterPropertyPartialDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver), IL2CPP.Il2CppObjectBaseToPtr(target), IL2CPP.ManagedStringToIl2Cpp(propertyPath));
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00011EF9 File Offset: 0x000100F9
		public static void TryRegisterPropertyPartial(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.TryRegisterPropertyPartialDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver), IL2CPP.Il2CppObjectBaseToPtr(target), IL2CPP.ManagedStringToIl2Cpp(propertyPath));
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x00011F17 File Offset: 0x00010117
		public static void UnregisterPropertyPartial(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.UnregisterPropertyPartialDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver), IL2CPP.Il2CppObjectBaseToPtr(target), IL2CPP.ManagedStringToIl2Cpp(propertyPath));
		}

		// Token: 0x04001BD2 RID: 7122
		private static readonly DrivenPropertyManager.UnregisterPropertiesDelegate UnregisterPropertiesDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.UnregisterPropertiesDelegate>("UnityEngine.DrivenPropertyManager::UnregisterProperties");

		// Token: 0x04001BD3 RID: 7123
		private static readonly DrivenPropertyManager.RegisterPropertyPartialDelegate RegisterPropertyPartialDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.RegisterPropertyPartialDelegate>("UnityEngine.DrivenPropertyManager::RegisterPropertyPartial");

		// Token: 0x04001BD4 RID: 7124
		private static readonly DrivenPropertyManager.TryRegisterPropertyPartialDelegate TryRegisterPropertyPartialDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.TryRegisterPropertyPartialDelegate>("UnityEngine.DrivenPropertyManager::TryRegisterPropertyPartial");

		// Token: 0x04001BD5 RID: 7125
		private static readonly DrivenPropertyManager.UnregisterPropertyPartialDelegate UnregisterPropertyPartialDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.UnregisterPropertyPartialDelegate>("UnityEngine.DrivenPropertyManager::UnregisterPropertyPartial");

		// Token: 0x02000B8D RID: 2957
		// (Invoke) Token: 0x0600357A RID: 13690
		private delegate void UnregisterPropertiesDelegate(IntPtr driver);

		// Token: 0x02000B8E RID: 2958
		// (Invoke) Token: 0x0600357C RID: 13692
		private delegate void RegisterPropertyPartialDelegate(IntPtr driver, IntPtr target, IntPtr propertyPath);

		// Token: 0x02000B8F RID: 2959
		// (Invoke) Token: 0x0600357E RID: 13694
		private delegate void TryRegisterPropertyPartialDelegate(IntPtr driver, IntPtr target, IntPtr propertyPath);

		// Token: 0x02000B90 RID: 2960
		// (Invoke) Token: 0x06003580 RID: 13696
		private delegate void UnregisterPropertyPartialDelegate(IntPtr driver, IntPtr target, IntPtr propertyPath);
	}
}
